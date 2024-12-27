using ClayManaged;

namespace Mud.Elements;

public class Layout : MudElement
{
    public Clay_LayoutAlignmentX AlignmentX { get; set; } = Clay_LayoutAlignmentX.CLAY_ALIGN_X_LEFT;
    public Clay_LayoutAlignmentY AlignmentY { get; set; } = Clay_LayoutAlignmentY.CLAY_ALIGN_Y_TOP;
    public ushort ChildGap { get; set; } = 10;
    public Clay_LayoutDirection Direction { get; set; } = Clay_LayoutDirection.CLAY_TOP_TO_BOTTOM;
    
    public ushort Padding { get; set; } = 10;
    public SizingMode Sizing { get; set; } = SizingMode.Fit;
    
    public Layout()
    {
        Id = "layout" + this.GetHashCode();
    }
    
    public override void Render()
    {
        ClayMacros.ElementInternal(() =>
        {
            ClayMacros.Id(Id, () =>
            ClayMacros.Layout(new Clay_LayoutConfig()
            {
                sizing = Sizing.ToClay(),
                childAlignment = new Clay_ChildAlignment()
                {
                    x = AlignmentX,
                    y = AlignmentY
                },
                padding = ClayMacros.Padding(Padding),
                layoutDirection = Direction,
                childGap = ((ushort)ChildGap)
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