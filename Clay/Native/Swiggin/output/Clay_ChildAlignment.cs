//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_ChildAlignment : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_ChildAlignment(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_ChildAlignment obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_ChildAlignment obj) {
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

  ~Clay_ChildAlignment() {
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
          ClayLibraryPINVOKE.delete_Clay_ChildAlignment(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_LayoutAlignmentX x {
    set {
      ClayLibraryPINVOKE.Clay_ChildAlignment_x_set(swigCPtr, (int)value);
    } 
    get {
      Clay_LayoutAlignmentX ret = (Clay_LayoutAlignmentX)ClayLibraryPINVOKE.Clay_ChildAlignment_x_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_LayoutAlignmentY y {
    set {
      ClayLibraryPINVOKE.Clay_ChildAlignment_y_set(swigCPtr, (int)value);
    } 
    get {
      Clay_LayoutAlignmentY ret = (Clay_LayoutAlignmentY)ClayLibraryPINVOKE.Clay_ChildAlignment_y_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_ChildAlignment() : this(ClayLibraryPINVOKE.new_Clay_ChildAlignment(), true) {
  }

}
