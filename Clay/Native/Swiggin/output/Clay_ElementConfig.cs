//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_ElementConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_ElementConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_ElementConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_ElementConfig obj) {
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

  ~Clay_ElementConfig() {
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
          ClayLibraryPINVOKE.delete_Clay_ElementConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay__ElementConfigType type {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfig_type_set(swigCPtr, (int)value);
    } 
    get {
      Clay__ElementConfigType ret = (Clay__ElementConfigType)ClayLibraryPINVOKE.Clay_ElementConfig_type_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_ElementConfigUnion config {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfig_config_set(swigCPtr, Clay_ElementConfigUnion.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfig_config_get(swigCPtr);
      Clay_ElementConfigUnion ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_ElementConfigUnion(cPtr, false);
      return ret;
    } 
  }

  public Clay_ElementConfig() : this(ClayLibraryPINVOKE.new_Clay_ElementConfig(), true) {
  }

}
