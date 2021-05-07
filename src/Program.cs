using System;
using System.Security.Cryptography;

namespace Lncodes.Example.Abstract
{
    public class Program
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected Program() { }

        static void Main()
        {
            //Create Enemy Instance
            var enemy = GetRandomEnemy();
            enemy.Run();
            enemy.Walk();
            enemy.Attack();
        }

        /// <summary>
        /// Method to random enemy
        /// </summary>
        /// <return cref="EnemyController"></return>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when random value > 2</exception>
        private static EnemyController GetRandomEnemy()
        {
            switch (new Random().Next(3))
            {
                case 0:
                    return new TrollEnemyController();
                case 1:
                    return new GoblinEnemyController();
                case 2:
                    return new OrcEnemyController();
                default:
                    const string exceptionMessage = "Random value out of range";
                    throw new ArgumentOutOfRangeException(exceptionMessage);
            }
        }
    }
}