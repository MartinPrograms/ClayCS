//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay__LayoutElementTreeNodeArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay__LayoutElementTreeNodeArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay__LayoutElementTreeNodeArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay__LayoutElementTreeNodeArray obj) {
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

  ~Clay__LayoutElementTreeNodeArray() {
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
          ClayLibraryPINVOKE.delete_Clay__LayoutElementTreeNodeArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint capacity {
    set {
      ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_capacity_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_capacity_get(swigCPtr);
      return ret;
    } 
  }

  public uint length {
    set {
      ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_length_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_length_get(swigCPtr);
      return ret;
    } 
  }

  public Clay__LayoutElementTreeNode internalArray {
    set {
      ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_internalArray_set(swigCPtr, Clay__LayoutElementTreeNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay__LayoutElementTreeNodeArray_internalArray_get(swigCPtr);
      Clay__LayoutElementTreeNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay__LayoutElementTreeNode(cPtr, false);
      return ret;
    } 
  }

  public Clay__LayoutElementTreeNodeArray() : this(ClayLibraryPINVOKE.new_Clay__LayoutElementTreeNodeArray(), true) {
  }

}
