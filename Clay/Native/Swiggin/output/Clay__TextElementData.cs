//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Clay__TextElementData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Clay__TextElementData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Clay__TextElementData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Clay__TextElementData obj) {
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

  ~Clay__TextElementData() {
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
          ClayLibraryPINVOKE.delete_Clay__TextElementData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Clay_String text {
    set {
      ClayLibraryPINVOKE.Clay__TextElementData_text_set(swigCPtr, Clay_String.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay__TextElementData_text_get(swigCPtr);
      Clay_String ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_String(cPtr, false);
      return ret;
    } 
  }

  public Clay_Dimensions preferredDimensions {
    set {
      ClayLibraryPINVOKE.Clay__TextElementData_preferredDimensions_set(swigCPtr, Clay_Dimensions.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay__TextElementData_preferredDimensions_get(swigCPtr);
      Clay_Dimensions ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay_Dimensions(cPtr, false);
      return ret;
    } 
  }

  public uint elementIndex {
    set {
      ClayLibraryPINVOKE.Clay__TextElementData_elementIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = ClayLibraryPINVOKE.Clay__TextElementData_elementIndex_get(swigCPtr);
      return ret;
    } 
  }

  public Clay__StringArraySlice wrappedLines {
    set {
      ClayLibraryPINVOKE.Clay__TextElementData_wrappedLines_set(swigCPtr, Clay__StringArraySlice.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = ClayLibraryPINVOKE.Clay__TextElementData_wrappedLines_get(swigCPtr);
      Clay__StringArraySlice ret = (cPtr == global::System.IntPtr.Zero) ? null : new Clay__StringArraySlice(cPtr, false);
      return ret;
    } 
  }

  public Clay__TextElementData() : this(ClayLibraryPINVOKE.new_Clay__TextElementData(), true) {
  }

}
