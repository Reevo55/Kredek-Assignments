using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Classes
{
    class NightGuest : Guest
    {
        public int howManyNights;
        public bool alreadyInRoom = false;

        public NightGuest(string name, int money, int howManyNights) : base(name, money)
        {
            this.howManyNights = howManyNights;
        }

        /// <summary>
        /// Pay for entire stay in the Inn
        /// </summary>
        /// <param name="goldPerNight"></param>
        /// <returns></returns>
        public int PayForStay(int goldPerNight)
        {
            int wholePay = howManyNights * goldPerNight;
            if (wholePay <= money)
            {
                if (wholePay + TipInnkeeper(goldPerNight) <= money)
                {
                    int sum = wholePay + TipInnkeeper(goldPerNight);
                    this.money -= sum;
                    return sum;
                }
                else
                { this.money -= wholePay; return wholePay; }

            }
            else return 0;
        }
        /// <summary>
        /// Return value of a tip for stay
        /// </summary>
        /// <param name="goldPerNight"></param>
        /// <returns></returns>
        public override int TipInnkeeper(int goldPerNight)
        {
            return howManyNights * goldPerNight * (1/5);
        }

        public int getHowManyNights() { return howManyNights; }
    }
}
