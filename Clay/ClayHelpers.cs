using System.Numerics;
using System.Runtime.InteropServices;

namespace ClayManaged;

public class ClayHelpers
{ 
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Clay_String_N
    {
        public int length;
        public char *chars;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Clay_Color_N
    {
        public float r;
        public float g;
        public float b;
        public float a;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Clay_Dimensions_N
    {
        public float width;
        public float height;
    }
    
    public enum Clay_TextElementConfigWrapMode_N
    {
        CLAY_TEXT_WRAP_WORDS,
        CLAY_TEXT_WRAP_NEWLINES,
        CLAY_TEXT_WRAP_NONE,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Clay_TextElementConfig_N{
        public Clay_Color_N textColor;
        public ushort fontId;
        public ushort fontSize;
        public ushort letterSpacing;
        public ushort lineHeight;
        public Clay_TextElementConfigWrapMode_N wrapMode;
    }
    public unsafe delegate Clay_Dimensions_N MeasureTextDelegate(Clay_String_N* str, Clay_TextElementConfig_N* config);

    [global::System.Runtime.InteropServices.DllImport("ClayLibrary", EntryPoint="SetMeasureText")]
    /*
     typedef Clay_Dimensions (*MeasureTextDelegate)(Clay_String* str, Clay_TextElementConfig* config);

        extern "C" SWIGEXPORT void SWIGSTDCALL SetMeasureText(MeasureTextDelegate measureText) {
            
            Clay_SetMeasureTextFunction(measureText);
        }

     */

    public static extern void SetMeasureText(MeasureTextDelegate measureText);
    
    public static Clay_Arena Init(MeasureTextDelegate measureTextDelegate)
    {
        var totalMemorySize = ClayLibrary.Clay_MinMemorySize();
        var arena = ClayLibrary.Clay_CreateArenaWithCapacityAndMemory(totalMemorySize, UnsafeUtils.Alloc(totalMemorySize));
        ClayLibrary.Clay_Initialize(arena, new Clay_Dimensions()
        {
            width = 100,
            height = 100
        });

        ClayLibrary.Clay_SetLayoutDimensions(new Clay_Dimensions()
        {
            width = 100,
            height = 100
        });
        
        var ptr = Marshal.GetFunctionPointerForDelegate(measureTextDelegate);
        SetMeasureText(measureTextDelegate); // Native DLL function
        
        return arena;
    }
    
    public static void SetMouseState(Vector2 pos, bool isDown)
    {
        ClayLibrary.Clay_SetPointerState(new Clay_Vector2()
        {
            x = pos.X,
            y = pos.Y
        }, isDown);
    }

    public static void SetScrollState(float getMouseWheelMove, float deltaTime)
    {
        ClayLibrary.Clay_UpdateScrollContainers(true, new Clay_Vector2()
        {
            x = 0,
            y = getMouseWheelMove
        }, deltaTime);
    }

    public static void SetWindowSize(int getScreenWidth, int getScreenHeight)
    {
        ClayLibrary.Clay_SetLayoutDimensions(new Clay_Dimensions()
        {
            width = getScreenWidth,
            height = getScreenHeight
        });
    }

    public static void BeginLayout()
    {
        ClayLibrary.Clay_BeginLayout();
    }

    public static Clay_RenderCommand[] Render()
    {
        var renders = ClayLibrary.Clay_EndLayout().ToArray();
        return renders;
    }

    public static bool PointerOver(string button1)
    {
        var strid = ClayLibrary.Clay_GetElementId(button1.ToClay());
        return ClayLibrary.Clay_PointerOver(strid);
    }

    public static void Debug()
    {
        ClayLibrary.Clay_SetDebugModeEnabled(true);
    }
}