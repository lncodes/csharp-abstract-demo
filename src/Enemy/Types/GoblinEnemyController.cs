using System;

namespace Lncodes.Examples.Abstract;

public sealed class GoblinEnemyController : EnemyController
{
    // Initial stamina for the goblin.
    protected override int Stamina { get; set; } = 10;

    ///<inheritdoc cref="EnemyController.Run"/>
    public override void Run()
    {
        Stamina -= 4;
        Console.WriteLine("Goblin is running");
        Console.WriteLine($"Goblin's remaining stamina: {Stamina}");
        Console.WriteLine();
    }

    ///<inheritdoc cref="EnemyController.Rest"/>
    public override void Rest()
    {
        Stamina++;
        Console.WriteLine("Goblin is resting");
        Console.WriteLine($"Goblin's remaining stamina: {Stamina}");
    }
}