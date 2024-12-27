using ClayManaged;

namespace Mud;

/// <summary>
/// Mud is an easy to use wrapper on top of the clay library.
/// </summary>
public class Mud
{
    public bool Debug { get; set; }
    
    public Mud(bool debug = false)
    {
        Debug = debug;
    }
    
    public List<MudElement> Elements { get; set; } = new();

    public void Add(MudElement action)
    {
        Elements.Add(action);
    }
    
    public void Render()
    {
        if (Debug)
            ClayHelpers.Debug();
        
        foreach (var action in Elements.ToArray())
        {
            action._InternalRender();
        }
    }
}