//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay_LayoutElementHashMapItem : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay_LayoutElementHashMapItem(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay_LayoutElementHashMapItem obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay_LayoutElementHashMapItem obj) {
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

  ~Clay_LayoutElementHashMapItem() {
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
          ClayLibraryPINVOKE.delete_Clay_LayoutElementHashMapItem(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_BoundingBox boundingBox {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_boundingBox_set(swigCPtr, Clay_BoundingBox.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_boundingBox_get(swigCPtr);
      Clay_BoundingBox ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_BoundingBox(cPtr, false);
      return ret;
    } 
  }

  public Clay_ElementId elementId {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_elementId_set(swigCPtr, Clay_ElementId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_elementId_get(swigCPtr);
      Clay_ElementId ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_ElementId(cPtr, false);
      return ret;
    } 
  }

  public Clay_LayoutElement layoutElement {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_layoutElement_set(swigCPtr, Clay_LayoutElement.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_layoutElement_get(swigCPtr);
      Clay_LayoutElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_LayoutElement(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_Clay_ElementId_Clay_PointerData_intptr_t__void onHoverFunction {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_onHoverFunction_set(swigCPtr, SWIGTYPE_p_f_Clay_ElementId_Clay_PointerData_intptr_t__void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_onHoverFunction_get(swigCPtr);
      SWIGTYPE_p_f_Clay_ElementId_Clay_PointerData_intptr_t__void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_Clay_ElementId_Clay_PointerData_intptr_t__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_intptr_t hoverFunctionUserData {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_hoverFunctionUserData_set(swigCPtr, SWIGTYPE_p_intptr_t.getCPtr(value));
      if (ClayLibraryPINVOKE.SWIGPendingException.Pending) throw ClayLibraryPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_intptr_t ret = new SWIGTYPE_p_intptr_t(ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_hoverFunctionUserData_get(swigCPtr), true);
      if (ClayLibraryPINVOKE.SWIGPendingException.Pending) throw ClayLibraryPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int nextIndex {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_nextIndex_set(swigCPtr, value);
    } 
    get {
      int ret = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_nextIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint generation {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_generation_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_generation_get(swigCPtr);
      return ret;
    } 
  }

  public Clay__DebugElementData debugData {
    set {
      ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_debugData_set(swigCPtr, Clay__DebugElementData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay_LayoutElementHashMapItem_debugData_get(swigCPtr);
      Clay__DebugElementData ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay__DebugElementData(cPtr, false);
      return ret;
    } 
  }

  public Clay_LayoutElementHashMapItem() : this(ClayLibraryPINVOKE.new_Clay_LayoutElementHashMapItem(), true) {
  }

}
