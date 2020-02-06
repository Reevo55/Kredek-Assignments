using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Enemy
{
    class Bandits : Enemy
    {
        public Bandits(string name) : base(name)
        {}

        /// <summary>
        /// bandyci napadaja i zabieraja zloto oraz piwo
        /// </summary>
        /// <param name="tavern"></param>
        public override void DoDamage(Tavern tavern)
        {
            Random r = new Random();
            tavern.gold -= r.Next(30);
            tavern.beer -= r.Next(20);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
