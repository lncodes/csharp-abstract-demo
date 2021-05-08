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
        private static void Main()
        {
            var enemyId = RandomEnemyId();
            var enemy = CreateEnemyTyeps(enemyId);
            enemy.Run();
            enemy.Walk();
            enemy.Attack();
        }
              
        /// <summary>
        /// Method to random enemy
        /// </summary>
        /// <return cref="EnemyController"></return>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when random value > 2</exception>
        private static EnemyController CreateEnemyTyeps(int enemyId)
        {
            switch (enemyId)
            {
                case 0:
                    return new OrcEnemyController();
                case 1:
                    return new TrollEnemyController();
                case 2:
                    return new GoblinEnemyController();
                default:
                    throw new ArgumentOutOfRangeException(nameof(enemyId));
            }
        }

        /// <summary>
        /// Method for random enemy id
        /// </summary>
        /// <returns cref=int></returns>
        private static int RandomEnemyId()
        {
            int ammountOfEnemyType = 3;
            return new Random().Next(ammountOfEnemyType);
        }
    }
}