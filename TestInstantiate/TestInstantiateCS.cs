using Godot;
using System;

public partial class TestInstantiateCS : ForLoopCS
{
    [Export] private PackedScene Scene { get; set; }
    
    public override void Do()
    {
        Node root = Scene.Instantiate<Node>();
        root.QueueFree();
    }
}
