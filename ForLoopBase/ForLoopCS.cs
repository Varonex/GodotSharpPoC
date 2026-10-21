using Godot;
using System;

public abstract partial class ForLoopCS : Node
{
    [Export(PropertyHint.Range, "0, 1, 1, or_greater")] public uint MaxIterations { get; set; } = 1_000_000;
    
    public override void _Ready()
    {
        GD.Print("Début du script...");
        ulong start = Time.GetTicksMsec();
        ulong end;

        for (int i = 0; i < MaxIterations; i++)
            Do();

        end = Time.GetTicksMsec();
        GD.Print("Fin du script... ", end - start, "ms");
    }

    public abstract void Do();
}
