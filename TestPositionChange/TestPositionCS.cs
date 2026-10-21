using Godot;
using System;

public partial class TestPositionCS : ForLoopCS
{
    [Export] public Node2D Target { get; set; }
    
    public override void Do()
    {
        Vector2 pos = Target.Position;
        pos.X += 1;
        Target.Position = pos;
    }
}
