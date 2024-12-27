using ClayManaged;

namespace Mud.Elements;

public class Rectangle : MudElement
{
    public Clay_Color Color { get; set; } = new Clay_Color()
    {
        r = 100,
        g = 100,
        b = 100,
        a = 100
    };
    
    public Rectangle()
    {
        this.Id = "rectangle" + this.GetHashCode();
    }
    
    public override void Render()
    {
        ClayMacros.ElementInternal(() =>
        {
            ClayMacros.Id(Id, () =>
            ClayMacros.Rectangle(new Clay_RectangleElementConfig()
            {
                color = Color
            }, () =>
            {
                foreach (var element in Elements.ToArray())
                {
                    element._InternalRender();
                }
            }));
        });
    }
}