using Greenhorn_Innkeeper_.ActivitiesClasses;
using Greenhorn_Innkeeper_.Classes;
using Greenhorn_Innkeeper_.Enemy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenhorn_Innkeeper_
{
    public partial class FormMain : Form
    {
        private string path = System.IO.Path.GetFullPath("data\\names.txt"); // lista imion fantasy
        private string pathBeerFoodMoney = System.IO.Path.GetFullPath("data\\moneyFoodBeer.txt"); // path do miejsca z money beer i gold txt
        private List<string> listOfFantasyNames = new List<string>();


        Tavern tavern;
        List<Guest> listOfGuests = new List<Guest>();

        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        //tworze poczatkowe warunki gry
        private void FormMain_Load(object sender, EventArgs e)
        {
            tavern = new Tavern(10, 10, 10, listOfGuests);

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    listOfFantasyNames.Add(s);
                }
            }

            for(int i=0; i < 3; i ++)
            {
                listOfGuests.Add(GenerateGuest());
                MessageBox.Show("W karczmie znajduje się aktualnie "  + listOfGuests[i].GetName() + "!");
            }

            listViewGuests.Scrollable = true;
            listViewGuests.Items.Clear();
            listViewGuests.Columns.Add("");
            ListViewChanged();

            timerTime.Enabled = true;
            timerTime.Start();
            timerTime.Interval = 5000;
            progressBarDay.Maximum = 24;
            timerTime.Tick += new EventHandler(timerTime_Tick);

            this.tavern.rooms[0].SetLabel(labelRoom1);
            this.tavern.rooms[1].SetLabel(labelRoom2);
            this.tavern.rooms[2].SetLabel(labelRoom3);
            this.tavern.rooms[3].SetLabel(labelRoom4);

            UpdateResources();

        }

        /// <summary>
        /// Tworzy postać, randomowy generator gości karczy
        /// </summary>
        /// <returns></returns>
        private Guest GenerateGuest()
        {
            Random r = new Random();

            int nightOrTavern = r.Next(10);

            int brawlerChance = r.Next(100);
            if (nightOrTavern > 7)
            {
                return new NightGuest(listOfFantasyNames[r.Next(listOfFantasyNames.Count - 1)], r.Next(100), r.Next(4));
            } else
            {
                bool brawler = false;
                if (brawlerChance == 1) brawler = true;
                return new TavernGuest(listOfFantasyNames[r.Next(listOfFantasyNames.Count - 1)], r.Next(100), brawler);
            }

        }
        /// <summary>
        /// Odswierzanie listView, przy zmianie stanu gosci
        /// </summary>
        private void ListViewChanged()
        {
            listViewGuests.Items.Clear();
            for(int i = 0; i < listOfGuests.Count; i++)
            {
                listViewGuests.Items.Add(listOfGuests[i].GetName() + " Złoto: " + listOfGuests[i].GetMoney());
            }
        }

        /// <summary>
        /// dodanie jednego goscia
        /// </summary>
        private void AddGuest()
        {
            Guest guest = GenerateGuest();
            listOfGuests.Add(guest);
            MessageBox.Show("Do karczmy przybył " + guest.GetName() + "!");
            ListViewChanged();
        }
        /// <summary>
        /// goscie ktorzy maja zero pieniedzy, oraz jeden randomowy wychodzi
        /// </summary>
        private void GuestsLeaves()
        {
            List<int> listOfGuestsToRemove = new List<int>();
            for(int i = 0; i < listOfGuests.Count; i++)
            {
                if (listOfGuests[i].GetMoney() <= 3)
                {
                    MessageBox.Show("Gość o imieniu " + listOfGuests[i].GetName() + " wychodzi!");
                    listOfGuestsToRemove.Add(i);
                }
            }
            for (int ii = 0; ii < listOfGuestsToRemove.Count; ii++)
            {
                listOfGuests.RemoveAt(listOfGuestsToRemove[ii]);
            }

            Random r = new Random();
            int rand = r.Next(listOfGuests.Count);
            listOfGuests[rand].GetName();
            MessageBox.Show("Gość o imieniu " + listOfGuests[rand].GetName() + " wychodzi!");
            listOfGuests.RemoveAt(rand);

            ListViewChanged();

        }

        /// <summary>
        /// update dnia, w ktorym sie znajdujemy
        /// </summary>
        private void UpdateDay()
        {
            labelDay.Text = "Dzień: " + tavern.day;
        }
        /// <summary>
        /// losowe wydarzenia oraz caly dzien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            if(progressBarDay.Value < 24)
            {
                if (progressBarDay.Value % 5 == 0) GuestDoesSomething();
                if(progressBarDay.Value % 10 == 0)
                {
                    GuestsLeaves();
                    GuestsArrive();
                }
                if (progressBarDay.Value % 17 == 0) PossibleEnemy();

                progressBarDay.Value++;
            } else
            {
                progressBarDay.Value = 0;
                tavern.day++;
                tavern.gold -= 5;
                MessageBox.Show("Przeznaczasz pieniadze za utrzymanie karczmy 5 złota.");
                UpdateDay();
                tavern.UpdateRooms();
                NightGuestsReserveRoom();

            }
        }
        /// <summary>
        /// moze sie zdarzyc ze enemy zaatakuje, to jest wlasnie po to
        /// </summary>
        private void PossibleEnemy()
        {
            Random r = new Random();

            int randomNum = r.Next(100);

            if(randomNum > 70)
            {
                Rats rats = new Rats("Brunatne szczury!", 2);

                rats.DoDamage(this.tavern);
                MessageBox.Show(rats.GetName() + " atakuja! Tracisz zywnosc!");

            }
            else if(randomNum < 5)
            {
                Bandits bandits = new Bandits("Szkarłatna zgraja!");

                bandits.DoDamage(this.tavern);
                MessageBox.Show(bandits.GetName() + " atakuja! Tracisz piwo i monety!!!");
            }
            UpdateResources();
            ListViewChanged();
        }
        /// <summary>
        /// Goscie ktorzy chca zostac na noc rezerwuja pokoje
        /// </summary>
        private void NightGuestsReserveRoom()
        {
            for(int i=0; i < listOfGuests.Count; i++)
            {
                if(listOfGuests[i] is NightGuest)
                {
                    NightGuest nightGuest = (NightGuest)listOfGuests[i];
                    tavern.ReserveRoom(nightGuest);
                    MessageBox.Show(nightGuest.GetName() + " właśnie zarezerował pokój!");
                }
            }
            UpdateResources();
            ListViewChanged();
        }
        /// <summary>
        /// Funkcja do tworzenia randomowej ilosci gosci
        /// </summary>
        private void GuestsArrive()
        {
            Random r = new Random();

            for(int ii = 0; ii < r.Next(3); ii++)
            {
                AddGuest();
            }
        }
        /// <summary>
        /// Goscie moga kupic piwo oraz jedzenie
        /// </summary>
        private void GuestDoesSomething()
        {
            Random r = new Random();

            int randomValue = r.Next(10);
            Guest randomGuest = listOfGuests[r.Next(listOfGuests.Count - 1)];

            if (randomValue > 3)
            {
                tavern.ServeBeer(randomGuest);
                MessageBox.Show(randomGuest.GetName() + " kupił właśnie piwo!");
            }
            else
            {
                tavern.ServeFood(randomGuest);
                MessageBox.Show(randomGuest.GetName() + " kupił właśnie jedzenie!");
            }
            ListViewChanged();
            UpdateResources();
        }

        /// <summary>
        /// aktualizacja zasobow
        /// </summary>
        private void UpdateResources()
        {
            if (tavern.gold < 0 || tavern.beer <= 0 || tavern.food <= 0) lost();
            this.labelGoldNumber.Text = tavern.gold.ToString();
            this.labelBeerNumber.Text = tavern.beer.ToString();
            this.labelFoodNumber.Text = tavern.food.ToString();
        }
        /// <summary>
        /// funkcja gdy gracz przegra, zasoby <= 0
        /// </summary>
        private void lost()
        {
            timerTime.Stop();

            MessageBox.Show("Niestety nie udało ci się utrzymać karczmy! Wytrwałeś " + tavern.day + " dni");
            this.Close();
        }
        /// <summary>
        /// przejscie na targ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResupply_Click(object sender, EventArgs e)
        {
            string gold = tavern.gold.ToString();
            string beer = tavern.beer.ToString();
            string food = tavern.food.ToString();

            using (StreamWriter streamWriter = new StreamWriter(pathBeerFoodMoney))
            {
                streamWriter.Flush();
                streamWriter.WriteLine(gold);
                streamWriter.WriteLine(beer);
                streamWriter.WriteLine(food);
            }

            timerTime.Stop();
            buttonPause.Visible = true;
            FormMarketPlace formMarketPlace = new FormMarketPlace();
            formMarketPlace.Show();

        }
        /// <summary>
        /// odpauzowanei gry po przejsciu z marketu spowrotem do karczmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPause_Click(object sender, EventArgs e)
        {
            buttonPause.Visible = false;
            timerTime.Start();
            using (StreamReader streamReader = File.OpenText(pathBeerFoodMoney))
            {
                tavern.gold = Int32.Parse(streamReader.ReadLine());
                tavern.beer = Int32.Parse(streamReader.ReadLine());
                tavern.food = Int32.Parse(streamReader.ReadLine());
            }
            UpdateResources();
        }
        /// <summary>
        /// stworzenie gry pokera ktora, zabiera pieniadze ale generuje nowych gosci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPoker_Click(object sender, EventArgs e)
        {
            List<Guest> pokerList = new List<Guest>();

            for(int i=0; i < 6; i ++)
            {
                if(i < listOfGuests.Count)
                pokerList.Add(listOfGuests[i]);
            }

            Poker poker = new Poker("Poker", pokerList);

            if (poker.requiredGoldToStart <= this.tavern.gold)
            {
                tavern.gold -= poker.requiredGoldToStart;

                poker.CalculateWinner().SetMoney(poker.requiredGoldToStart);

                MessageBox.Show("Wydajesz 10 złota, żeby zorganizować grę pokera! Twoj turniej pokera przyniosl zainteresowanie! Przychodzą kolejne osoby!");
                AddGuest();
                AddGuest();
                AddGuest();

                UpdateResources();
                ListViewChanged();
            }
            else MessageBox.Show("Nie masz wystarczająco złota! (10)");
        }
        /// <summary>
        /// pijanska gra, funkcja zabiera piwo ale generuje nowych gosci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrinkingGame_Click(object sender, EventArgs e)
        {
            DrinkingGame drinkingGame = new DrinkingGame("Drinking game!", listOfGuests, 2);

            if (tavern.beer > drinkingGame.HowManyBeersIsNeeded())
            {
                drinkingGame.CalculateWinner().SetMoney(100);

                this.tavern.beer -= drinkingGame.HowManyBeersIsNeeded();

                MessageBox.Show("Rozdajesz" + drinkingGame.HowManyBeersIsNeeded() + ", żeby zorganizować pijańską grę! Przychodzą kolejne osoby!");
                for(int i=0; i < listOfGuests.Count/2; i++)
                {
                    AddGuest();
                }
                UpdateResources();
                ListViewChanged();
            }
            else MessageBox.Show("Nie masz wystarczająco piw! (min " + drinkingGame.HowManyBeersIsNeeded() + ")");
        }
    }
}

