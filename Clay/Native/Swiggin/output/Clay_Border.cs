//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_Border : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_Border(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_Border obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_Border obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~Clay_Border() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ClayLibraryPINVOKE.delete_Clay_Border(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint width {
    set {
      ClayLibraryPINVOKE.Clay_Border_width_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_Border_width_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_Color color {
    set {
      ClayLibraryPINVOKE.Clay_Border_color_set(swigCPtr, Clay_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_Border_color_get(swigCPtr);
      Clay_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Color(cPtr, false);
      return ret;
    } 
  }

  public Clay_Border() : this(ClayLibraryPINVOKE.new_Clay_Border(), true) {
  }

}
