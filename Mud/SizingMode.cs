using ClayManaged;

namespace Mud;

public enum SizingMode
{
    Fit,
    Fill
}

public static class MudExtensions
{
    public static Clay_Sizing ToClay(this SizingMode mode)
    {
        return mode switch
        {
            SizingMode.Fit => ClayMacros.SizingFit(),
            SizingMode.Fill => ClayMacros.SizingGrow(),
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
        };
    }
}