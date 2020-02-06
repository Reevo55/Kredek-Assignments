using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Enemy
{
    class Rats : Enemy
    {
        protected int howMuchFoodDamagePerOneRat;
        protected int howManyRats;

        public Rats(string name, int howMuchFoodDamagePerOneRat) : base(name)
        {
            this.howMuchFoodDamagePerOneRat = howMuchFoodDamagePerOneRat;
            Random r = new Random();
            howManyRats = r.Next(4);
        }

        /// <summary>
        /// szczury wyjadaja zywnosc z tawerny
        /// </summary>
        /// <param name="tavern"></param>
        public override void DoDamage(Tavern tavern)
        {
            tavern.food -= howMuchFoodDamagePerOneRat * howManyRats;
        }
    }
}
