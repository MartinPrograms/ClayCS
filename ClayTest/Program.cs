// See https://aka.ms/new-console-template for more information

using ClayManaged;
using ClayRendererGL;
using Mud;
using Mud.Elements;
using Raylib_cs;
using Rectangle = Mud.Elements.Rectangle;

var window = new ClayWindow(800,600,"Clay Test");

RaylibManager.LoadFont("Roboto-Regular.ttf");

// Im using mud here as a way of abstracting the clay render calls, however you can use clay directly if you want.
// For example:
// ClayMacros.Rectangle(new Clay_RectangleElementConfig(){
// whatever
// }, () => {
//     ClayMacros.Text(new Clay_TextElementConfig(){
//         whatever
//     });
// });

var mud = new Mud.Mud(true);

var root = new Layout()
{
    Sizing = SizingMode.Fill
};

root.Elements = new List<MudElement>()
{
    new Rectangle()
    {
        Clickable = true,
        ClickAction = () =>
        {
            AddElement();
        },
        Elements = new List<MudElement>()
        {
            new Text()
            {
                TextContent = "Hello, World!",
                FontID = RaylibManager.GetFontID("Roboto-Regular.ttf"),
                FontSize = 20,
                Color = new Clay_Color()
                {
                    r = 255,
                    g = 255,
                    b = 255,
                    a = 255
                }
            }
        }
    }
};

void AddElement()
{
    root.Elements.Add(new Rectangle()
    {
        Elements = new List<MudElement>()
        {
            new Text()
            {
                TextContent = "Hello, World!",
                FontID = RaylibManager.GetFontID("Roboto-Regular.ttf"),
                FontSize = 20,
                Color = new Clay_Color()
                {
                    r = 255,
                    g = 255,
                    b = 255,
                    a = 255
                }
            }
        }
    });
}

mud.Add(root);

window.Render += () =>
{
    Mud.Input.Left = Raylib.IsMouseButtonReleased(MouseButton.Left);
    mud.Render();
};

window.Run();

RaylibManager.UnloadAllFonts();
