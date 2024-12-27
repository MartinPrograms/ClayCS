using ClayManaged;

namespace Mud;

/// <summary>
/// Base class for all mud elements.
/// </summary>
public abstract class MudElement
{
    public string Id { get; set; }

    public List<MudElement> Elements { get; set; } = new();
    
    public abstract void Render();
    
    internal void _InternalRender()
    {
        if (Clickable)
        {
            if (Input.Left && ClayHelpers.PointerOver(Id))
            {
                ClickAction?.Invoke();
            }
        }
        
        Render();
    }
    public bool Clickable { get; set; }
    public Action ClickAction { get; set; }
}