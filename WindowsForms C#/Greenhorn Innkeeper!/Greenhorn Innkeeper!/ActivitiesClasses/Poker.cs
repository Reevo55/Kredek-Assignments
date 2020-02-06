using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greenhorn_Innkeeper_.Classes;

namespace Greenhorn_Innkeeper_.ActivitiesClasses
{
    class Poker : Activity
    {
        protected int maxPlayers = 6;
        public int requiredGoldToStart = 10;

        public Poker(string name, List<Guest> guestsTakingPart) : base(name, guestsTakingPart)
        {
            this.timeOfPlay = 100000; // milisec
        }

        /// <summary>
        /// losowe wylonienie zwyciezcy
        /// </summary>
        /// <returns></returns>
        public override Guest CalculateWinner()
        {
            Random r = new Random();
            return guestsTakingPart.ElementAt(r.Next(guestsTakingPart.Count-1));
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
