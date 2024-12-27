using System.Runtime.InteropServices;

namespace ClayManaged;

public static class UnsafeUtils
{
    public static HandleRef Alloc(uint size)
    {
        var ptr = Marshal.AllocHGlobal((int)size);
        
        return new HandleRef(null, ptr);
    }
    
    public static void Free(IntPtr ptr)
    {
        Marshal.FreeHGlobal(ptr);
    }
    
    public static unsafe Clay_String ToClay(this string value)
    {
        var ptr = ClayLibraryPINVOKE.new_Clay_String();
        var str = new Clay_String(ptr, true);
        
        str.length = value.Length;
        str.chars = value;
        
        return str;
    }
    
    public static unsafe Clay_RenderCommand[] ToArray(this Clay_RenderCommandArray array)
    {
        var beginElement = array.internalArray; // This is a single item, the pointer of this is the beginning of the array
        var count = array.length;
        
        var commands = new Clay_RenderCommand[count];
        
        var elementPtr = Clay_RenderCommand.getCPtr(beginElement); // Returns a handle ref
        var size = ClayLibrary.Clay_RenderCommand_size_t(); // Returns the size of the struct, as a uint
        for (var i = 0; i < count; i++)
        {
            var element = new Clay_RenderCommand((elementPtr.Handle + (nint)(i * size)), false);
            commands[i] = element;
        }
        
        return commands;
    }
}