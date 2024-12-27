using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ClayManaged;
using Raylib_cs;

namespace ClayRendererGL;

public static class RaylibExtensions
{
public static unsafe ClayHelpers.Clay_Dimensions_N Raylib_MeasureText(ClayHelpers.Clay_String_N* str, ClayHelpers.Clay_TextElementConfig_N* config)
    {
        byte* bytes = (byte*)str->chars;
        var text = Encoding.UTF8.GetString(bytes, str->length);
        var font = RaylibManager.GetFont(config->fontId);

        var size = new Vector2();
        foreach (var character in text)
        {
            var charSize = Raylib.MeasureTextEx(font, character.ToString(), config->fontSize, config->letterSpacing);
            size.X += charSize.X;
            size.Y = Math.Max(size.Y, charSize.Y);
        }
        
        return new ClayHelpers.Clay_Dimensions_N()
        {
            width = size.X,
            height = size.Y,
        };
    }

    public static Color ToRaylib(this Clay_Color color)
    {
        if (color.r < 0) color.r = 0;
        if (color.g < 0) color.g = 0;
        if (color.b < 0) color.b = 0;
        if (color.a < 0) color.a = 0;
        if (color.r > 255) color.r = 255;
        if (color.g > 255) color.g = 255;
        if (color.b > 255) color.b = 255;
        if (color.a > 255) color.a = 255;
        try
        {
            return new Color((int)color.r, (int)color.g, (int)color.b, (int)color.a);
        }catch
        {
            return Color.White;
        }
    }
}