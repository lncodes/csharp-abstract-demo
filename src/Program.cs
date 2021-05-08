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

        /// <summary>
        /// Main program
        /// </summary>
        private static void Main()
        {
            var enemyId = GetRandomEnemyTypesId();
            var enemy = CreateEnemyTypesById(enemyId);
            enemy.Run();
            enemy.Walk();
            enemy.Attack();
        }
              
        /// <summary>
        /// Method to random enemy
        /// </summary>
        /// <return cref="EnemyController"></return>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when random value > 2</exception>
        private static EnemyController CreateEnemyTypesById(int enemyTypesId)
        {
            switch (enemyTypesId)
            {
                case 0:
                    return new OrcEnemyController();
                case 1:
                    return new TrollEnemyController();
                case 2:
                    return new GoblinEnemyController();
                default:
                    throw new ArgumentOutOfRangeException(nameof(enemyTypesId));
            }
        }

        /// <summary>
        /// Method for random enemy types id
        /// </summary>
        /// <returns cref=int></returns>
        private static int GetRandomEnemyTypesId()
        {
            var ammountOfEnemyTypes = 3;
            return RandomNumberGenerator.GetInt32(ammountOfEnemyTypes);
        }
    }
}