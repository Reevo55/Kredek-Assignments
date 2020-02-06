using Greenhorn_Innkeeper_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.ActivitiesClasses
{
    class DrinkingGame : Activity
    {
        public int neededBeersPerPerson = 2;

        public DrinkingGame(string name, List<Guest> guestsTakingPart, int neededBeersPerPerson) : base(name, guestsTakingPart)
        {
            this.neededBeersPerPerson = neededBeersPerPerson;
        }

        /// <summary>
        /// sprawdzenie ile piw jest potrzeba dla graczy
        /// </summary>
        /// <returns></returns>
        public int HowManyBeersIsNeeded()
        {
            return guestsTakingPart.Count * neededBeersPerPerson;
        }
    }
}
