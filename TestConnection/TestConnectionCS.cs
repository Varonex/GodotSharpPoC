using Godot;
using System;

public partial class TestConnectionCS : ForLoopCS
{
    [Signal]
    private delegate void MySignalEventHandler(int a, string b);
    
    public override void Do()
    {
        Connect(SignalName.MySignal, Callable.From<int, string>(_Callback), (uint)ConnectFlags.OneShot);
        EmitSignal(SignalName.MySignal, 1, "a");
    }
    
    private void _Callback(int a, string b) {}
}
