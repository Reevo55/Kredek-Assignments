using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Classes
{
    abstract class Guest
    {
        protected string name;
        protected int money;

        protected Guest(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public int MyProperty { get; set; }

        /// <summary>
        /// virtual function to buy beer, tavernGuest may give tips so it is virtual
        /// </summary>
        /// <param name="beerCost"></param>
        /// <returns></returns>
        virtual public int BuyBeer(int beerCost)
        {
            if (this.money >= beerCost)
            {
                this.money -= beerCost;
                return beerCost;
            }
            else return 0;
        }
        /// <summary>
        /// virtual function to buy food, tavenGuest may give tips so it is virtual
        /// </summary>
        /// <param name="foodCost"></param>
        /// <returns></returns>
        virtual public int BuyFood(int foodCost)
        {
            if (this.money >= foodCost)
            {
                this.money -= foodCost;
                return foodCost;
            }
            else return 0;
        }
        abstract public int TipInnkeeper(int cost);

        public string GetName() { return name; }
        public int GetMoney() { return money; }
        public void SetMoney(int money) { this.money = money; }
    }
}
