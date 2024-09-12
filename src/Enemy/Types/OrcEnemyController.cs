using System;

namespace Lncodes.Example.Abstract;

public sealed class OrcEnemyController : EnemyController
{
    // Initial stamina for the orc.
    protected override int Stamina { get; set; } = 20;

    ///<inheritdoc cref="EnemyController.Run"/>
    public override void Run()
    {
        Stamina -= 5;
        Console.WriteLine("Orc is running");
        Console.WriteLine($"Orc's remaining stamina: {Stamina}");
        Console.WriteLine();
    }

    ///<inheritdoc cref="EnemyController.Rest"/>
    public override void Rest()
    {
        Stamina += 2;
        Console.WriteLine("Orc is resting");
        Console.WriteLine($"Orc's Remaining stamina: {Stamina}");
    }
}