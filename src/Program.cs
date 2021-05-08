using System;

namespace Lncodes.Example.Abstract
{
    public class Program
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected Program() { }

        /// <summary>
        /// Main program
        /// </summary>
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
                default:
                    return new OrcEnemyController();
            }
        }
    }
}