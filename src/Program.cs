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
            var random = new Random(3);
            var randomValue = random.Next();
            switch (randomValue)
            {
                case 0:
                    return new TrollEnemyController();
                case 1:
                    return new GoblinEnemyController();
                case 2:
                    return new OrcEnemyController();
                default:
                    throw new ArgumentOutOfRangeException("Random value out of range");
            }
        }
    }
}