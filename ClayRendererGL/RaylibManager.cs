using Raylib_cs;

namespace ClayRendererGL;

public static class RaylibManager
{
    public static Dictionary<string, Font> Fonts { get; } = new();
    
    public static void LoadFont(string fontPath)
    {
        var font = Raylib.LoadFont(fontPath);
        Fonts.Add(fontPath, font);
    }
    
    public static void UnloadFont(string font)
    {
        Raylib.UnloadFont(Fonts[font]);
        
        Fonts.Remove(font);
    }
    
    public static void UnloadAllFonts()
    {
        foreach (var font in Fonts)
        {
            Raylib.UnloadFont(font.Value);
        }
        
        Fonts.Clear();
    }
    
    public static Font GetFont(int index)
    {
        if (index < 0 || index >= Fonts.Count)
        {
            return Raylib.GetFontDefault();
        }
        return Fonts[Fonts.Keys.ElementAt(index)];
    }

    public static int GetFontID(string robotoRegularTtf)
    {
        return Fonts.Keys.ToList().IndexOf(robotoRegularTtf);
    }
}