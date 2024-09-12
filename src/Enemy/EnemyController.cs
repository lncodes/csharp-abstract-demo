using System;

namespace Lncodes.Example.Abstract;

public abstract class EnemyController
{
    protected abstract int Stamina { get; set; }

    /// <summary>
    /// Abstract method to make the enemy run.
    /// </summary>
    public abstract void Run();

    /// <summary>
    /// Abstract method to make the enemy rest.
    /// </summary>
    public abstract void Rest();

    /// <summary>
    /// Displays the initial stamina of the enemy.
    /// </summary>
    public void DisplayInitialStaminaPoint()
    {
        Console.WriteLine($"Initial monster stamina: {Stamina}");
        Console.WriteLine();
    }
}