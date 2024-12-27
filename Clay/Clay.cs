namespace ClayManaged;

public class ClayMacros
{
    //// Public Macro API ------------------------

    // #ifdef __cplusplus
    // #define CLAY__CONFIG_WRAPPER(type, ...) __VA_ARGS__
    public static T CONFIG_WRAPPER<T>(T value)
    {
        return value;
    }    // #else
    // #define CLAY__CONFIG_WRAPPER(type, ...) (type) __VA_ARGS__
    // #endif
    //
    // #define CLAY__MAX(x, y) (((x) > (y)) ? (x) : (y))
    public static T MAX<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) > 0 ? x : y;
    }
    // #define CLAY__MIN(x, y) (((x) < (y)) ? (x) : (y))
    public static T MIN<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) < 0 ? x : y;
    }
    //
    // #define CLAY_LAYOUT(...) Clay__AttachLayoutConfig(Clay__StoreLayoutConfig(CLAY__CONFIG_WRAPPER(Clay_LayoutConfig, __VA_ARGS__)))
    public static void Layout(Clay_LayoutConfig args, params Action[] actions)
    {
        ClayLibrary.Clay__AttachLayoutConfig(
            ClayLibrary.Clay__StoreLayoutConfig(CONFIG_WRAPPER(args)));
        
        ExecuteActions(actions);
    }    
    //
    // #define CLAY_RECTANGLE(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .rectangleElementConfig = Clay__StoreRectangleElementConfig(CLAY__INIT(Clay_RectangleElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_RECTANGLE))
    //
    public static void Rectangle(Clay_RectangleElementConfig rectangleConfig, params Action[] actions)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            rectangleElementConfig = ClayLibrary.Clay__StoreRectangleElementConfig(CONFIG_WRAPPER(rectangleConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_RECTANGLE);
        
        ExecuteActions(actions);
    }

    // New method for CLAY_TEXT_CONFIG
    public static Clay_TextElementConfig TextConfig(Clay_TextElementConfig textConfig)
    {
        return ClayLibrary.Clay__StoreTextElementConfig(CONFIG_WRAPPER(textConfig));
    }    
    //
    // #define CLAY_IMAGE(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .imageElementConfig = Clay__StoreImageElementConfig(CLAY__INIT(Clay_ImageElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_IMAGE))
    //
    
    public static void Image(Clay_ImageElementConfig imageConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            imageElementConfig = ClayLibrary.Clay__StoreImageElementConfig(CONFIG_WRAPPER(imageConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_IMAGE);
    }
    
    // #define CLAY_FLOATING(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .floatingElementConfig = Clay__StoreFloatingElementConfig(CLAY__INIT(Clay_FloatingElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_FLOATING_CONTAINER))
    
    public static void Floating(Clay_FloatingElementConfig floatingConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            floatingElementConfig = ClayLibrary.Clay__StoreFloatingElementConfig(CONFIG_WRAPPER(floatingConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_FLOATING_CONTAINER);
    }
    
    // #define CLAY_CUSTOM_ELEMENT(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .customElementConfig = Clay__StoreCustomElementConfig(CLAY__INIT(Clay_CustomElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_CUSTOM))

    public static void CustomElement(Clay_CustomElementConfig customConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            customElementConfig = ClayLibrary.Clay__StoreCustomElementConfig(CONFIG_WRAPPER(customConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_CUSTOM);
    }
    
    // #define CLAY_SCROLL(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .scrollElementConfig = Clay__StoreScrollElementConfig(CLAY__INIT(Clay_ScrollElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_SCROLL_CONTAINER))
    
    public static void Scroll(Clay_ScrollElementConfig scrollConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            scrollElementConfig = ClayLibrary.Clay__StoreScrollElementConfig(CONFIG_WRAPPER(scrollConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_SCROLL_CONTAINER);
    }
    
    // #define CLAY_BORDER(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .borderElementConfig = Clay__StoreBorderElementConfig(CLAY__INIT(Clay_BorderElementConfig) __VA_ARGS__) }, CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER))
    
    public static void Border(Clay_BorderElementConfig borderConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            borderElementConfig = ClayLibrary.Clay__StoreBorderElementConfig(CONFIG_WRAPPER(borderConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
    }
    
    // #define CLAY_BORDER_OUTSIDE(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .borderElementConfig = Clay__StoreBorderElementConfig(CLAY__INIT(Clay_BorderElementConfig) { .left = __VA_ARGS__, .right = __VA_ARGS__, .top = __VA_ARGS__, .bottom = __VA_ARGS__ }) }, CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER))
    
    public static void BorderOutside(Clay_BorderElementConfig borderConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            borderElementConfig = ClayLibrary.Clay__StoreBorderElementConfig(CONFIG_WRAPPER(borderConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
    }
    
    // #define CLAY_BORDER_OUTSIDE_RADIUS(width, color, radius) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .borderElementConfig = Clay__StoreBorderElementConfig(CLAY__INIT(Clay_BorderElementConfig) { .left = { width, color }, .right = { width, color }, .top = { width, color }, .bottom = { width, color }, .cornerRadius = { radius, radius, radius, radius } })}, CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER))
    
    public static void BorderOutsideRadius(Clay_BorderElementConfig borderConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            borderElementConfig = ClayLibrary.Clay__StoreBorderElementConfig(CONFIG_WRAPPER(borderConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
    }
    
    // #define CLAY_BORDER_ALL(...) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .borderElementConfig = Clay__StoreBorderElementConfig(CLAY__INIT(Clay_BorderElementConfig) { .left = __VA_ARGS__, .right = __VA_ARGS__, .top = __VA_ARGS__, .bottom = __VA_ARGS__, .betweenChildren = __VA_ARGS__ }) }, CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER))
    
    public static void BorderAll(Clay_BorderElementConfig borderConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            borderElementConfig = ClayLibrary.Clay__StoreBorderElementConfig(CONFIG_WRAPPER(borderConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
    }
    
    // #define CLAY_BORDER_ALL_RADIUS(width, color, radius) Clay__AttachElementConfig(CLAY__CONFIG_WRAPPER(Clay_ElementConfigUnion, { .borderElementConfig = Clay__StoreBorderElementConfig(CLAY__INIT(Clay_BorderElementConfig) { .left = { width, color }, .right = { width, color }, .top = { width, color }, .bottom = { width, color }, .betweenChildren = { width, color }, .cornerRadius = { radius, radius, radius, radius }}) }))
    
    public static void BorderAllRadius(Clay_BorderElementConfig borderConfig)
    {
        var elementConfig = new Clay_ElementConfigUnion
        {
            borderElementConfig = ClayLibrary.Clay__StoreBorderElementConfig(CONFIG_WRAPPER(borderConfig))
        };
        
        ClayLibrary.Clay__AttachElementConfig(elementConfig, Clay__ElementConfigType.CLAY__ELEMENT_CONFIG_TYPE_BORDER_CONTAINER);
    }
    
    // #define CLAY_CORNER_RADIUS(radius) CLAY__INIT(Clay_CornerRadius) { radius, radius, radius, radius }
    
    public static Clay_CornerRadius CornerRadius(byte radius)
    {
        return new Clay_CornerRadius
        {
            topLeft = radius,
            topRight = radius,
            bottomLeft = radius,
            bottomRight = radius
        };
    }
    
    // #define CLAY__STRUCT_1_ARGS(a) a
    // #define CLAY__STRUCT_0_ARGS() {}
    // #define CLAY__STRUCT_OVERRIDE(_0, _1, NAME, ...) NAME
    
    public static Clay_Color Color(byte r, byte g, byte b, byte a)
    {
        return new Clay_Color
        {
            r = r,
            g = g,
            b = b,
            a = a
        };
    }
    
    // #define CLAY__SIZING_FIT_INTERNAL(...) CLAY__INIT(Clay_SizingAxis) { .sizeMinMax = CLAY__INIT(Clay_SizingMinMax) __VA_ARGS__, .type = CLAY__SIZING_TYPE_FIT }
    
    public static Clay_SizingAxis SizingFitInternal(Clay_SizingMinMax sizeMinMax)
    {
        return new Clay_SizingAxis
        {
            sizeMinMax = sizeMinMax,
            type = Clay__SizingType.CLAY__SIZING_TYPE_FIT
        };
    }
    
    // #define CLAY_SIZING_FIT(...) CLAY__SIZING_FIT_INTERNAL(CLAY__STRUCT_OVERRIDE("empty", ##__VA_ARGS__, CLAY__STRUCT_1_ARGS, CLAY__STRUCT_0_ARGS)(__VA_ARGS__))
    
    public static Clay_SizingAxis SizingFit(Clay_SizingMinMax sizeMinMax)
    {
        return SizingFitInternal(sizeMinMax);
    }
    
    public static Clay_Sizing SizingFit()
    {
        return new Clay_Sizing
        {
            width = SizingFitInternal(new Clay_SizingMinMax()),
            height = SizingFitInternal(new Clay_SizingMinMax())
        };
    }
    
    // #define CLAY__SIZING_GROW_INTERNAL(...) CLAY__INIT(Clay_SizingAxis) { .sizeMinMax = CLAY__INIT(Clay_SizingMinMax) __VA_ARGS__, .type = CLAY__SIZING_TYPE_GROW }
    
    public static Clay_SizingAxis SizingGrowInternal(Clay_SizingMinMax sizeMinMax)
    {
        return new Clay_SizingAxis
        {
            sizeMinMax = sizeMinMax,
            type = Clay__SizingType.CLAY__SIZING_TYPE_GROW
        };
    }
    
    // #define CLAY_SIZING_GROW(...) CLAY__SIZING_GROW_INTERNAL(CLAY__STRUCT_OVERRIDE("empty", ##__VA_ARGS__, CLAY__STRUCT_1_ARGS, CLAY__STRUCT_0_ARGS)(__VA_ARGS__))
    
    public static Clay_SizingAxis SizingGrow(Clay_SizingMinMax sizeMinMax)
    {
        return SizingGrowInternal(sizeMinMax);
    }
    
    public static Clay_Sizing SizingGrow()
    {
        return new Clay_Sizing
        {
            width = SizingGrowInternal(new Clay_SizingMinMax()),
            height = SizingGrowInternal(new Clay_SizingMinMax())
        };
    }
    
    // #define CLAY_SIZING_FIXED(fixedSize) CLAY__INIT(Clay_SizingAxis) { .sizeMinMax = { fixedSize, fixedSize }, .type = CLAY__SIZING_TYPE_FIXED }
    
    public static Clay_SizingAxis SizingFixed(float fixedSize)
    {
        return new Clay_SizingAxis
        {
            sizeMinMax = new Clay_SizingMinMax
            {
                min = fixedSize,
                max = fixedSize
            },
            type = Clay__SizingType.CLAY__SIZING_TYPE_FIXED
        };
    }
    
    public static Clay_Sizing SizingFixed(float width, float height)
    {
        return new Clay_Sizing
        {
            width = SizingFixed(width),
            height = SizingFixed(height)
        };
    }
    
    // #define CLAY_SIZING_PERCENT(percentOfParent) CLAY__INIT(Clay_SizingAxis) { .sizePercent = (percentOfParent), .type = CLAY__SIZING_TYPE_PERCENT }
    
    public static Clay_SizingAxis SizingPercent(float percentOfParent)
    {
        return new Clay_SizingAxis
        {
            sizePercent = percentOfParent,
            type = Clay__SizingType.CLAY__SIZING_TYPE_PERCENT
        };
    }
    
    // #define CLAY_ID(label) Clay__AttachId(Clay__HashString(CLAY_STRING(label), 0, 0))
    
    public static void Id(string label, params Action[] actions)
    {
        ClayLibrary.Clay__AttachId(ClayLibrary.Clay__HashString(label.ToClay(), 0, 0));
        
        ExecuteActions(actions);
    }
    
    // #define CLAY_IDI(label, index) Clay__AttachId(Clay__HashString(CLAY_STRING(label), index, 0))
    
    public static void Idi(string label, uint index)
    {
        ClayLibrary.Clay__AttachId(ClayLibrary.Clay__HashString(label.ToClay(), (index), (0)));
    }
    
    // #define CLAY_ID_LOCAL(label) CLAY_IDI_LOCAL(label, 0)
    
    public static void IdLocal(string label)
    {
        IdiLocal(label, 0);
    }
    
    // #define CLAY_IDI_LOCAL(label, index) Clay__AttachId(Clay__HashString(CLAY_STRING(label), Clay_LayoutElementArray_Get(&Clay__layoutElements, Clay__int32_tArray_Get(&Clay__openLayoutElementStack, Clay__openLayoutElementStack.length - 2))->children.length + 1, Clay__GetOpenLayoutElement()->id))
    
    public static void IdiLocal(string label, uint index)
    {
        ClayLibrary.Clay__AttachId(ClayLibrary.Clay__HashString(label.ToClay(), (index), (0))); // TODO: Implement Clay__layoutElements, Clay__openLayoutElementStack, Clay__int32_tArray_Get, Clay__GetOpenLayoutElement
    }
    
    // #define CLAY__STRING_LENGTH(s) ((sizeof(s) / sizeof((s)[0])) - sizeof((s)[0]))
    
    public static byte StringLength(string s)
    {
        return (byte)(s.Length - 1);
    }
    
    // #define CLAY_STRING(string) CLAY__INIT(Clay_String) { .length = CLAY__STRING_LENGTH(string), .chars = (string) }
    
    public static Clay_String String(string s)
    {
        return new Clay_String
        {
            length = StringLength(s),
            chars = s
        };
    }
    
    // static int CLAY__ELEMENT_DEFINITION_LATCH = 0;
    
    // #define CLAY__ELEMENT_INTERNAL(...) \
    // 	for (\
    // 		CLAY__ELEMENT_DEFINITION_LATCH = (Clay__OpenElement(), __VA_ARGS__, Clay__ElementPostConfiguration(), 0); \
    // 		CLAY__ELEMENT_DEFINITION_LATCH < 1; \
    // 		++CLAY__ELEMENT_DEFINITION_LATCH, Clay__CloseElement() \
    // 	)

    private static int CLAY__ELEMENT_DEFINITION_LATCH;

    // Method to handle the internal element logic
    // Method to handle the internal element logic
    public static void ElementInternal(params Action[] actions)
    { 
        CLAY__ELEMENT_DEFINITION_LATCH = 0;
        ClayLibrary.Clay__OpenElement();
        
        ExecuteActions(actions);
        ClayLibrary.Clay__ElementPostConfiguration();
        CLAY__ELEMENT_DEFINITION_LATCH = 0;

        while (CLAY__ELEMENT_DEFINITION_LATCH < 1)
        {
            CLAY__ELEMENT_DEFINITION_LATCH++;
            ClayLibrary.Clay__CloseElement();
        }
    }

    // Helper method to execute the actions
    private static int ExecuteActions(Action[] actions)
    {
        foreach (var action in actions)
        {
            action.Invoke();
        }
        return 0; // Return 0 to match the macro's behavior
    }
    
    // #define CLAY__6_ARGS(a, b, c, d, e, f) a, b, c, d, e, f
    // #define CLAY__5_ARGS(a, b, c, d, e) a, b, c, d, e
    // #define CLAY__4_ARGS(a, b, c, d) a, b, c, d
    // #define CLAY__3_ARGS(a, b, c) a, b, c
    // #define CLAY__2_ARGS(a, b) a, b
    // #define CLAY__1_ARGS(a) a
    // #define CLAY__0_ARGS() Clay__Noop()
    public static void Noop()
    {
        ClayLibrary.Clay__Noop();
    }
    
    // #define CLAY__ARGS_OVERRIDE(_0, _1, _2, _3, _4, _5, _6, NAME, ...) NAME
    
    //
    // // Publicly visible layout element macros -----------------------------------------------------
    // #define CLAY(...) CLAY__ELEMENT_INTERNAL(CLAY__ARGS_OVERRIDE("empty", ##__VA_ARGS__, CLAY__6_ARGS, CLAY__5_ARGS, CLAY__4_ARGS, CLAY__3_ARGS, CLAY__2_ARGS, CLAY__1_ARGS, CLAY__0_ARGS)(__VA_ARGS__))
    
    public static void Clay(params Action[] args)
    {
        ElementInternal(args);
    }
    
    // #define CLAY_TEXT(text, textConfig) Clay__OpenTextElement(text, textConfig)
    
    public static unsafe void Text(Clay_String text, Clay_TextElementConfig textConfig)
    {
        ClayLibrary.Clay__OpenTextElement(text, textConfig);
    }
    
    // #ifdef __cplusplus
    // #define CLAY__INIT(type) type
    // #define CLAY__ALIGNMENT(type) alignof(type)
    // #define CLAY_PACKED_ENUM : uint8_t
    // #else
    // #define CLAY__INIT(type) (type)
    // #define CLAY__ALIGNMENT(type) (offsetof(struct { char c; type x; }, x))
    // #define CLAY_PACKED_ENUM __attribute__((__packed__))
    // #endif
    public static Clay_ChildAlignment ChildAlignmentCenter()
    {
        return new Clay_ChildAlignment()
        {
            x = Clay_LayoutAlignmentX.CLAY_ALIGN_X_CENTER,
            y = Clay_LayoutAlignmentY.CLAY_ALIGN_Y_CENTER
        };
    }

    public static Clay_Padding Padding(int i)
    {
        return new Clay_Padding()
        {
            x = ((ushort)i),
            y = ((ushort)i)
        };
    }

    public static Clay_TextElementConfig DefaultTextConfig()
    {
        return new Clay_TextElementConfig()
        {
            textColor = new Clay_Color()
            {
                r = 255,
                g = 255,
                b = 255,
                a = 255
            },
            fontSize = ((ushort)20)
        };
    }
}