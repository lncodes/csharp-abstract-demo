using System;

namespace Lncodes.Example.Abstract
{
    public sealed class TrollEnemyController : EnemyController
    {
        ///<inheritdoc cref="EnemyController.Stamina"/>
        protected override int Stamina { get; set; } = 30;

        ///<inheritdoc cref="EnemyController.Run"/>
        public override void Run()
        {
            Stamina -= 3;
            Console.WriteLine("Troll run");
            Console.WriteLine($"Troll Stamina = {Stamina}");
            Console.WriteLine();
        }

        ///<inheritdoc cref="EnemyController.Attack"/>
        public override void Attack()
        {
            Stamina -= 4;
            base.Attack();
            Console.WriteLine($"Troll Stamina = {Stamina}");
        }
    }
}