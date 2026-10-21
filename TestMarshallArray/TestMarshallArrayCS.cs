using Godot;
using System;

public partial class TestMarshallArrayCS : ForLoopCS
{
    [Export] private Godot.Collections.Array Array { get; set; } = new();
    private StringName _methodName { get; set; } = "ifjdsioujiofdsjio";

    public override void Do()
    {
        PropagateCall(_methodName, Array);
    }
}
