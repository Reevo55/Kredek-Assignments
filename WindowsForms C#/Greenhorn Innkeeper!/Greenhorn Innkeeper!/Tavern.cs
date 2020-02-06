using Greenhorn_Innkeeper_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_
{
    class Tavern
    {
        public int happinesOfCustomers;

        public int day;

        public int gold;
        public int beer;
        public int food;

        public int beerCost = 2;
        public int foodCost = 3;
        public int roomCost = 5;

        public List<Room> rooms = new List<Room> { new Room("Room1", false,0), new Room("Room2", false, 0), new Room("Room3", false, 0), new Room("Room4", false, 0) };

        public List<Guest> listOfGuests;

        public Tavern(int gold, int beer, int food, List<Guest> listOfGuests)
        {
            this.gold = gold + 20; //Poniewaz musza miec duzo zlota na zostanie na noc
            this.beer = beer;
            this.food = food;
            this.listOfGuests = listOfGuests;
            this.day = 0;
            this.happinesOfCustomers = 0;
        }

        /// <summary>
        /// zaservowanie piwa
        /// </summary>
        /// <param name="guest"></param>
        public void ServeBeer(Guest guest)
        {
            gold += guest.BuyBeer(beerCost);
            beer--;
        }
        /// <summary>
        /// zaserwowanie jedzenia
        /// </summary>
        /// <param name="guest"></param>
        public void ServeFood(Guest guest)
        {
            gold += guest.BuyBeer(foodCost);
            food--;
        }
        /// <summary>
        /// rezerwacja pokoi przez gosci
        /// </summary>
        /// <param name="nightGuest"></param>
        /// <returns></returns>
        public int ReserveRoom(NightGuest nightGuest)
        {
            for (int i = 0; i < this.rooms.Count; i++)
            {
                if (this.rooms[i].taken == false)
                {
                    int payForStay = nightGuest.PayForStay(roomCost);
                    if (payForStay >= 0)
                    {
                        gold += payForStay;
                        nightGuest.alreadyInRoom = true;
                        this.rooms[i].label.Text = "Zajęte przez: " + nightGuest.GetName() + "!";
                        this.rooms[i].taken = true;
                        this.rooms[i].nightsRemains = nightGuest.getHowManyNights();
                        return nightGuest.getHowManyNights();
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// aktualizacja pokoi
        /// </summary>
        public void UpdateRooms()
        {
            for(int i=0; i < this.rooms.Count; i++)
            {
                this.rooms[i].nightsRemains--;
                if(this.rooms[i].nightsRemains <= 0)
                {
                    this.rooms[i].taken = false;
                    this.rooms[i].nightsRemains = 0;
                    this.rooms[i].label.Text = "Wolne!";
                }
            }
        }
    }
}
