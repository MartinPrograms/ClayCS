//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_ElementConfigUnion : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_ElementConfigUnion(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_ElementConfigUnion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_ElementConfigUnion obj) {
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

  ~Clay_ElementConfigUnion() {
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
          ClayLibraryPINVOKE.delete_Clay_ElementConfigUnion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_RectangleElementConfig rectangleElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_rectangleElementConfig_set(swigCPtr, Clay_RectangleElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_rectangleElementConfig_get(swigCPtr);
      Clay_RectangleElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_RectangleElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_TextElementConfig textElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_textElementConfig_set(swigCPtr, Clay_TextElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_textElementConfig_get(swigCPtr);
      Clay_TextElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_TextElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_ImageElementConfig imageElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_imageElementConfig_set(swigCPtr, Clay_ImageElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_imageElementConfig_get(swigCPtr);
      Clay_ImageElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_ImageElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_FloatingElementConfig floatingElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_floatingElementConfig_set(swigCPtr, Clay_FloatingElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_floatingElementConfig_get(swigCPtr);
      Clay_FloatingElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_FloatingElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_CustomElementConfig customElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_customElementConfig_set(swigCPtr, Clay_CustomElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_customElementConfig_get(swigCPtr);
      Clay_CustomElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_CustomElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_ScrollElementConfig scrollElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_scrollElementConfig_set(swigCPtr, Clay_ScrollElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_scrollElementConfig_get(swigCPtr);
      Clay_ScrollElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_ScrollElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_BorderElementConfig borderElementConfig {
    set {
      ClayLibraryPINVOKE.Clay_ElementConfigUnion_borderElementConfig_set(swigCPtr, Clay_BorderElementConfig.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_ElementConfigUnion_borderElementConfig_get(swigCPtr);
      Clay_BorderElementConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_BorderElementConfig(cPtr, false);
      return ret;
    } 
  }

  public Clay_ElementConfigUnion() : this(ClayLibraryPINVOKE.new_Clay_ElementConfigUnion(), true) {
  }

}
