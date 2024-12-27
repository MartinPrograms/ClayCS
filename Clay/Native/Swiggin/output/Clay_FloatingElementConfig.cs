//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_FloatingElementConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_FloatingElementConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_FloatingElementConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_FloatingElementConfig obj) {
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

  ~Clay_FloatingElementConfig() {
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
          ClayLibraryPINVOKE.delete_Clay_FloatingElementConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_Vector2 offset {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_offset_set(swigCPtr, Clay_Vector2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_FloatingElementConfig_offset_get(swigCPtr);
      Clay_Vector2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Vector2(cPtr, false);
      return ret;
    } 
  }

  public Clay_Dimensions expand {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_expand_set(swigCPtr, Clay_Dimensions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_FloatingElementConfig_expand_get(swigCPtr);
      Clay_Dimensions ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Dimensions(cPtr, false);
      return ret;
    } 
  }

  public ushort zIndex {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_zIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = ClayLibraryPINVOKE.Clay_FloatingElementConfig_zIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint parentId {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_parentId_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_FloatingElementConfig_parentId_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_FloatingAttachPoints attachment {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_attachment_set(swigCPtr, Clay_FloatingAttachPoints.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_FloatingElementConfig_attachment_get(swigCPtr);
      Clay_FloatingAttachPoints ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_FloatingAttachPoints(cPtr, false);
      return ret;
    } 
  }

  public Clay_PointerCaptureMode pointerCaptureMode {
    set {
      ClayLibraryPINVOKE.Clay_FloatingElementConfig_pointerCaptureMode_set(swigCPtr, (int)value);
    } 
    get {
      Clay_PointerCaptureMode ret = (Clay_PointerCaptureMode)ClayLibraryPINVOKE.Clay_FloatingElementConfig_pointerCaptureMode_get(swigCPtr);
      return ret;
    } 
  }

  public Clay_FloatingElementConfig() : this(ClayLibraryPINVOKE.new_Clay_FloatingElementConfig(), true) {
  }

}
