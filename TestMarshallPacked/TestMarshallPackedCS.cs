using Godot;
using System;

public partial class TestMarshallPackedCS : ForLoopCS
{
    [Export] private byte[] Packed { get; set; }

    public override void Do()
    {
        Marshalls.RawToBase64(Packed);
    }
}
