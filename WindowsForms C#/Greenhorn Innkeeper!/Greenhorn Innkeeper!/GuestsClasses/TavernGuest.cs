using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Classes
{
    class TavernGuest : Guest
    {
        // does guest likes to get into trouble?
        protected Boolean brawler;

        public TavernGuest(string name, int money, Boolean brawler) : base(name, money)
        {
            this.brawler = brawler;
        }

        /// <summary>
        /// Buying beer function
        /// </summary>
        /// <param name="beerCost"></param>
        /// <returns></returns>
        override
        public int BuyBeer(int beerCost)
        {
            if (this.money >= beerCost)
            {
                if (beerCost + TipInnkeeper(beerCost) >= money)
                {
                    int sum = beerCost + TipInnkeeper(beerCost);
                    this.money -= sum;
                    return sum;
                }
                else
                {
                    this.money -= beerCost;
                    return beerCost;
                }
            }
            else return 0;
        }

        /// <summary>
        /// function to buy food
        /// </summary>
        /// <param name="foodCost"></param>
        /// <returns></returns>
        override
        public int BuyFood(int foodCost)
        {
            if (this.money >= foodCost)
            {
                if (foodCost + TipInnkeeper(foodCost) >= money)
                {
                    int sum = foodCost + TipInnkeeper(foodCost);
                    this.money -= sum;
                    return sum;
                }
                else
                {
                    this.money -= foodCost;
                    return foodCost;
                }
            }
            else return 0;
        }

        /// <summary>
        /// Function returning value of a Tip
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public override int TipInnkeeper(int cost)
        {
            return cost * (1 / 10);
        }
    }
}
