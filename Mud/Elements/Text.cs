using ClayManaged;

namespace Mud.Elements;

public class Text : MudElement
{
    
    public string TextContent { get; set; } = "";
    public int FontID { get; set; } = 0;
    public ushort FontSize { get; set; } = 12;
    public Clay_Color Color { get; set; } = new Clay_Color()
    {
        r = 255,
        g = 255,
        b = 255,
        a = 255
    };
    
    public Text()
    {
        this.Id = "text" + this.GetHashCode();
    }
    
    public override void Render()
    {
        ClayMacros.ElementInternal(() =>
        {
            ClayMacros.Id(Id, () =>
                ClayMacros.Text(TextContent.ToClay(), new Clay_TextElementConfig()
                {
                    fontId = (ushort)FontID,
                    fontSize = (ushort)FontSize,
                    textColor = Color
                }));
        });
    }
}