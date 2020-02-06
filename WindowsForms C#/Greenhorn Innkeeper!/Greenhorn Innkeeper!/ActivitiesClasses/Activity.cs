using Greenhorn_Innkeeper_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.ActivitiesClasses
{
    class Activity
    {
        protected string name;
        protected List<Guest> guestsTakingPart;
        protected int timeOfPlay;

        public Activity(string name, List<Guest> guestsTakingPart)
        {
            this.name = name;
            this.guestsTakingPart = guestsTakingPart;
        }

        // Calculate winner, virtual because in some cases there can be more winners etc
        virtual public Guest CalculateWinner()
        {
            Random r = new Random();
            return this.guestsTakingPart[r.Next(guestsTakingPart.Count-1)];
        }

    }
}
