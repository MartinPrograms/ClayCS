%module ClayLibrary
%{

#define CLAY_IMPLEMENTATION

#include "clay.h"

size_t Clay_ChildAlignment_size_t() { 
    return sizeof(Clay_ChildAlignment); 
}

size_t Clay_SizingMinMax_size_t() { 
    return sizeof(Clay_SizingMinMax); 
}

size_t Clay_SizingAxis_size_t() { 
    return sizeof(Clay_SizingAxis); 
}

size_t Clay_Sizing_size_t() { 
    return sizeof(Clay_Sizing); 
}

size_t Clay_Padding_size_t() { 
    return sizeof(Clay_Padding); 
}

size_t Clay_LayoutConfig_size_t() { 
    return sizeof(Clay_LayoutConfig); 
}

size_t Clay_RectangleElementConfig_size_t() { 
    return sizeof(Clay_RectangleElementConfig); 
}

size_t Clay_TextElementConfig_size_t() { 
    return sizeof(Clay_TextElementConfig); 
}

size_t Clay_ImageElementConfig_size_t() { 
    return sizeof(Clay_ImageElementConfig); 
}

size_t Clay_FloatingAttachPoints_size_t() { 
    return sizeof(Clay_FloatingAttachPoints); 
}

size_t Clay_FloatingElementConfig_size_t() { 
    return sizeof(Clay_FloatingElementConfig); 
}

size_t Clay_CustomElementConfig_size_t() { 
    return sizeof(Clay_CustomElementConfig); 
}

size_t Clay_ScrollElementConfig_size_t() { 
    return sizeof(Clay_ScrollElementConfig); 
}

size_t Clay_Border_size_t() { 
    return sizeof(Clay_Border); 
}

size_t Clay_BorderElementConfig_size_t() { 
    return sizeof(Clay_BorderElementConfig); 
}

size_t Clay_ElementConfigUnion_size_t() { 
    return sizeof(Clay_ElementConfigUnion); 
}

size_t Clay_ElementConfig_size_t() { 
    return sizeof(Clay_ElementConfig); 
}

size_t Clay_ScrollContainerData_size_t() { 
    return sizeof(Clay_ScrollContainerData); 
}

size_t Clay_RenderCommand_size_t() { 
    return sizeof(Clay_RenderCommand); 
}

size_t Clay_RenderCommandArray_size_t() { 
    return sizeof(Clay_RenderCommandArray); 
}

size_t Clay_PointerData_size_t() { 
    return sizeof(Clay_PointerData); 
}

size_t Clay_String_size_t() { 
    return sizeof(Clay_String); 
}

size_t Clay__StringArray_size_t() { 
    return sizeof(Clay__StringArray); 
}

size_t Clay_Arena_size_t() { 
    return sizeof(Clay_Arena); 
}

size_t Clay_Dimensions_size_t() { 
    return sizeof(Clay_Dimensions); 
}

size_t Clay_Vector2_size_t() { 
    return sizeof(Clay_Vector2); 
}

size_t Clay_Color_size_t() { 
    return sizeof(Clay_Color); 
}

size_t Clay_BoundingBox_size_t() { 
    return sizeof(Clay_BoundingBox); 
}

size_t Clay_ElementId_size_t() { 
    return sizeof(Clay_ElementId); 
}

size_t Clay_CornerRadius_size_t() { 
    return sizeof(Clay_CornerRadius); 
}

// create a delegate with the following signature, Clay_Dimensions delegate(Clay_String *text, Clay_TextElementConfig *config)
// This is used to measure text in the layout engine

typedef Clay_Dimensions (*MeasureTextDelegate)(Clay_String* str, Clay_TextElementConfig* config);

extern "C" SWIGEXPORT void SWIGSTDCALL SetMeasureText(MeasureTextDelegate measureText) {
    
    Clay_SetMeasureTextFunction(measureText);
}


%}

#define int8_t signed char
#define uint8_t unsigned char
#define int16_t short
#define uint16_t unsigned short
#define int32_t int
#define uint32_t unsigned int
#define int64_t long long
#define uint64_t unsigned long long

#define CLAY_IMPLEMENTATION
#define CLAY_OVERFLOW_TRAP
// The above line is needed to trap overflow errors in the layout engine ???
%include "clay.h"

// For each struct create a helper function to return the size of the struct
// This is used in arrays to offset the pointer to the next element

#include <stddef.h>


// Make it __cdecl so it can be called from C#
typedef Clay_Dimensions (*MeasureTextDelegate)(Clay_String* str, Clay_TextElementConfig* config);

extern "C" void SetMeasureText(MeasureTextDelegate measureText) {
    
    Clay_SetMeasureTextFunction(measureText);
}

size_t Clay_ChildAlignment_size_t() { 
    return sizeof(Clay_ChildAlignment); 
}

size_t Clay_SizingMinMax_size_t() { 
    return sizeof(Clay_SizingMinMax); 
}

size_t Clay_SizingAxis_size_t() { 
    return sizeof(Clay_SizingAxis); 
}

size_t Clay_Sizing_size_t() { 
    return sizeof(Clay_Sizing); 
}

size_t Clay_Padding_size_t() { 
    return sizeof(Clay_Padding); 
}

size_t Clay_LayoutConfig_size_t() { 
    return sizeof(Clay_LayoutConfig); 
}

size_t Clay_RectangleElementConfig_size_t() { 
    return sizeof(Clay_RectangleElementConfig); 
}

size_t Clay_TextElementConfig_size_t() { 
    return sizeof(Clay_TextElementConfig); 
}

size_t Clay_ImageElementConfig_size_t() { 
    return sizeof(Clay_ImageElementConfig); 
}

size_t Clay_FloatingAttachPoints_size_t() { 
    return sizeof(Clay_FloatingAttachPoints); 
}

size_t Clay_FloatingElementConfig_size_t() { 
    return sizeof(Clay_FloatingElementConfig); 
}

size_t Clay_CustomElementConfig_size_t() { 
    return sizeof(Clay_CustomElementConfig); 
}

size_t Clay_ScrollElementConfig_size_t() { 
    return sizeof(Clay_ScrollElementConfig); 
}

size_t Clay_Border_size_t() { 
    return sizeof(Clay_Border); 
}

size_t Clay_BorderElementConfig_size_t() { 
    return sizeof(Clay_BorderElementConfig); 
}

size_t Clay_ElementConfigUnion_size_t() { 
    return sizeof(Clay_ElementConfigUnion); 
}

size_t Clay_ElementConfig_size_t() { 
    return sizeof(Clay_ElementConfig); 
}

size_t Clay_ScrollContainerData_size_t() { 
    return sizeof(Clay_ScrollContainerData); 
}

size_t Clay_RenderCommand_size_t() { 
    return sizeof(Clay_RenderCommand); 
}

size_t Clay_RenderCommandArray_size_t() { 
    return sizeof(Clay_RenderCommandArray); 
}

size_t Clay_PointerData_size_t() { 
    return sizeof(Clay_PointerData); 
}

size_t Clay_String_size_t() { 
    return sizeof(Clay_String); 
}

size_t Clay__StringArray_size_t() { 
    return sizeof(Clay__StringArray); 
}

size_t Clay_Arena_size_t() { 
    return sizeof(Clay_Arena); 
}

size_t Clay_Dimensions_size_t() { 
    return sizeof(Clay_Dimensions); 
}

size_t Clay_Vector2_size_t() { 
    return sizeof(Clay_Vector2); 
}

size_t Clay_Color_size_t() { 
    return sizeof(Clay_Color); 
}

size_t Clay_BoundingBox_size_t() { 
    return sizeof(Clay_BoundingBox); 
}

size_t Clay_ElementId_size_t() { 
    return sizeof(Clay_ElementId); 
}

size_t Clay_CornerRadius_size_t() { 
    return sizeof(Clay_CornerRadius); 
}