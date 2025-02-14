using System;

namespace Lncodes.Examples.Abstract;

public sealed class TrollEnemyController : EnemyController
{
    // Initial stamina for the troll.
    protected override int Stamina { get; set; } = 30;

    ///<inheritdoc cref="EnemyController.Run"/>
    public override void Run()
    {
        Stamina -= 10;
        Console.WriteLine("Troll is running");
        Console.WriteLine($"Troll's remaining stamina: {Stamina}");
        Console.WriteLine();
    }

    ///<inheritdoc cref="EnemyController.Rest"/>
    public override void Rest()
    {
        Stamina += 4;
        Console.WriteLine("Troll is resting");
        Console.WriteLine($"Troll's remaining stamina: {Stamina}");
    }
}