using ClayManaged;
using Raylib_cs;

namespace ClayRendererGL;

public class ClayWindow
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Title { get; set; }
    
    private Clay_Arena _arena;
    
    public ClayWindow(int width, int height, string title)
    {
        Width = width;
        Height = height;
        Title = title;
        
        InitRaylib();
        InitClay();
    }

    private unsafe void InitClay()
    {
        _arena = ClayHelpers.Init(RaylibExtensions.Raylib_MeasureText);
    }

    private void InitRaylib()
    {
        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow | ConfigFlags.VSyncHint);
        Raylib.InitWindow(Width, Height, Title);
    }
    
    public Action Render { get; set; }
    
    public void Run()
    {
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            ClayHelpers.SetMouseState(Raylib.GetMousePosition(), Raylib.IsMouseButtonDown(MouseButton.Left));
            ClayHelpers.SetScrollState(Raylib.GetMouseWheelMove(), Raylib.GetFrameTime());
            ClayHelpers.SetWindowSize(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
            
            ClayHelpers.BeginLayout();
            
            Render?.Invoke();
            
            var renderCommands = ClayHelpers.Render();
            
            RaylibClayRenderer.Render(renderCommands);
            
            Raylib.EndDrawing();
        }
    }
}