//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_ElementId : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_ElementId(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_ElementId obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_ElementId obj) {
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

  ~Clay_ElementId() {
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
          ClayLibraryPINVOKE.delete_Clay_ElementId(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint id {
    set {
      ClayLibraryPINVOKE.Clay_ElementId_id_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_ElementId_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint offset {
    set {
      ClayLibraryPINVOKE.Clay_ElementId_offset_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_ElementId_offset_get(swigCPtr);
      return ret;
    } 
  }

  public uint baseId {
    set {
      ClayLibraryPINVOKE.Clay_ElementId_baseId_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_ElementId_baseId_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_String stringId {
    set {
      ClayLibraryPINVOKE.Clay_ElementId_stringId_set(swigCPtr, Clay_String.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementId_stringId_get(swigCPtr);
      Clay_String ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_String(cPtr, false);
      return ret;
    } 
  }

  public Clay_ElementId() : this(ClayLibraryPINVOKE.new_Clay_ElementId(), true) {
  }

}
