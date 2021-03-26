using System;

namespace Lncodes.Example.Abstract
{
    public sealed class OrcEnemyController : EnemyController
    {
        ///<inheritdoc cref="EnemyController.Stamina"/>
        protected override int Stamina { get; set; } = 20;

        ///<inheritdoc cref="EnemyController.Run"/>
        public override void Run()
        {
            Stamina -= 2;
            Console.WriteLine("Orc run");
            Console.WriteLine($"Orc Stamina = {Stamina}");
            Console.WriteLine();
        }

        ///<inheritdoc cref="EnemyController.Attack"/>
        public override void Attack()
        {
            Stamina -= 3;
            base.Attack();
            Console.WriteLine($"Orc Stamina = {Stamina}");
        }
    }
}