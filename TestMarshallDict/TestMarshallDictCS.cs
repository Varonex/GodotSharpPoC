using Godot;
using System;

public partial class TestMarshallDictCS : ForLoopCS
{
    public override void Do()
    {
        Json.Stringify(
            new Godot.Collections.Dictionary()
            {
                ["hello"] = "hi",
                ["hi"] = "hello"
            }
        );
    }
}
