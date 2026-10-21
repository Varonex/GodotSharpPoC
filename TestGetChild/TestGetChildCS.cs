using Godot;
using System;

public partial class TestGetChildCS : ForLoopCS
{
    public override void Do()
    {
        Node2D k = GetChild(0) as Node2D;
    }
}
