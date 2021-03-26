using System;

namespace Lncodes.Example.Abstract
{
    public sealed class GoblinEnemyController : EnemyController
    {
        ///<inheritdoc cref="EnemyController.Stamina"/>
        protected override int Stamina { get; set; } = 10;

        ///<inheritdoc cref="EnemyController.Run"/>
        public override void Run()
        {
            Stamina--;
            Console.WriteLine("Goblin run");
            Console.WriteLine($"Goblin Stamina = {Stamina}");
            Console.WriteLine();
        }

        ///<inheritdoc cref="EnemyController.Attack"/>
        public override void Attack()
        {
            Stamina -= 2;
            base.Attack();
            Console.WriteLine($"Goblin Stamina = {Stamina}");
        }
    }
}