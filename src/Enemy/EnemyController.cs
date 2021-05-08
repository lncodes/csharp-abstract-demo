using System;

namespace Lncodes.Example.Abstract
{
    public abstract class EnemyController
    {
        /// <value>Gets and Set the Stamina value</value>
        protected abstract int Stamina { get; set; }

        /// <summary>
        /// Abstract method to make enemy run
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// Virtual method to make enemy attack
        /// </summary>
        public virtual void Attack() =>
            Console.WriteLine("Enemy Attack");

        /// <summary>
        /// Method to make enemy walk
        /// </summary>
        public void Walk() =>
            Console.WriteLine("Enemy Walk \n");
    }
}