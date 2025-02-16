using System;

namespace Lncodes.AbstractDemo;

internal static class Program
{
    /// <summary>
    /// Entry point for the application.
    /// </summary>
    private static void Main()
    {
        var enemyId = GetRandomEnemyId();
        var enemy = CreateEnemyTypesById(enemyId);
        enemy.DisplayInitialStaminaPoint();
        enemy.Run();
        enemy.Rest();
        Console.ReadLine();
    }

    /// <summary>
    /// Creates an instance of an enemy controller based on the specified enemy ID.
    /// </summary>
    /// <param name="enemyId">The ID of the enemy type to create.</param>
    /// <returns>An instance of the <see cref="EnemyController"/> subclass corresponding to the enemy ID.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the enemy ID is out of the valid range.</exception>
    private static EnemyController CreateEnemyTypesById(int enemyId) =>
        enemyId switch
        {
            0 => new OrcEnemyController(),
            1 => new TrollEnemyController(),
            2 => new GoblinEnemyController(),
            _ => throw new ArgumentOutOfRangeException(nameof(enemyId)),
        };

    /// <summary>
    /// Generates a random enemy ID.
    /// </summary>
    /// <returns>A random enemy ID as an integer.</returns>
    private static int GetRandomEnemyId()
    {
        const int amountOfEnemyTypes = 3;
        return Random.Shared.Next(amountOfEnemyTypes);
    }
}