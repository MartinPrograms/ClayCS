//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_BorderElementConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_BorderElementConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_BorderElementConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_BorderElementConfig obj) {
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

  ~Clay_BorderElementConfig() {
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
          ClayLibraryPINVOKE.delete_Clay_BorderElementConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_Border left {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_left_set(swigCPtr, Clay_Border.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_left_get(swigCPtr);
      Clay_Border ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Border(cPtr, false);
      return ret;
    } 
  }

  public Clay_Border right {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_right_set(swigCPtr, Clay_Border.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_right_get(swigCPtr);
      Clay_Border ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Border(cPtr, false);
      return ret;
    } 
  }

  public Clay_Border top {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_top_set(swigCPtr, Clay_Border.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_top_get(swigCPtr);
      Clay_Border ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Border(cPtr, false);
      return ret;
    } 
  }

  public Clay_Border bottom {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_bottom_set(swigCPtr, Clay_Border.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_bottom_get(swigCPtr);
      Clay_Border ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Border(cPtr, false);
      return ret;
    } 
  }

  public Clay_Border betweenChildren {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_betweenChildren_set(swigCPtr, Clay_Border.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_betweenChildren_get(swigCPtr);
      Clay_Border ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Border(cPtr, false);
      return ret;
    } 
  }

  public Clay_CornerRadius cornerRadius {
    set {
      ClayLibraryPINVOKE.Clay_BorderElementConfig_cornerRadius_set(swigCPtr, Clay_CornerRadius.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_BorderElementConfig_cornerRadius_get(swigCPtr);
      Clay_CornerRadius ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_CornerRadius(cPtr, false);
      return ret;
    } 
  }

  public Clay_BorderElementConfig() : this(ClayLibraryPINVOKE.new_Clay_BorderElementConfig(), true) {
  }

}
