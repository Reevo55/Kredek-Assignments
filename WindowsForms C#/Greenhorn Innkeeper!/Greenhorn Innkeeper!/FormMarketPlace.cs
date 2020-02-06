using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenhorn_Innkeeper_
{
    public partial class FormMarketPlace : Form
    {
        private string pathBeerFoodMoney = System.IO.Path.GetFullPath("data\\moneyFoodBeer.txt");

        private int startBeer;
        private int startFood;
        private int gold;
        private int beer;
        private int food;

        private int price;

        public FormMarketPlace()
        {
            InitializeComponent();
        }

        /// <summary>
        /// przy zaladowaniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMarketPlace_Load(object sender, EventArgs e)
        {
            using (StreamReader streamReader = File.OpenText(pathBeerFoodMoney))
            {
                gold = Int32.Parse(streamReader.ReadLine());
                beer = Int32.Parse(streamReader.ReadLine());
                food = Int32.Parse(streamReader.ReadLine());
            }
            startBeer = beer;
            startFood = food;

            UpdateResources();
        }

        /// <summary>
        /// aktualizacja zasobow
        /// </summary>
        private void UpdateResources()
        {
            labelBeerNumber.Text = beer.ToString();
            labelFoodNumber.Text = food.ToString();
            labelGoldNumber.Text = gold.ToString();
            labelPrice.Text = "Cała cena to: " + price.ToString();
        }
        /// <summary>
        /// button do dodawania jedzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlusFood_Click(object sender, EventArgs e)
        {
            this.food++;
            this.price++;
            UpdateResources();
        }
        /// <summary>
        ///button do odejmowania jedzenia

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinusFood_Click(object sender, EventArgs e)
        {
            if (food == startFood) MessageBox.Show("Nie mozesz sprzedac towaru! Tylko kupic!");
            else
            {
                this.food--;
                this.price--;
            }
            UpdateResources();

        }
        /// <summary>
        /// button do dodawania piwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlusBeer_Click(object sender, EventArgs e)
        {
            this.beer++;
            this.price++;
            UpdateResources();

        }
        /// <summary>
        /// button do odejmowania piwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinusBeer_Click(object sender, EventArgs e)
        {
            if (beer == startBeer) MessageBox.Show("Nie mozesz sprzedac towaru! Tylko kupic!");
            else
            {
                this.beer--;
                this.price--;
            }
            UpdateResources();

        }
        /// <summary>
        /// klikniecie kupienia zasobow i powrot do karczmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (price > gold) MessageBox.Show("Nie stać cię!");
            else
            {
                string gold = (this.gold - price).ToString();
                string beer = this.beer.ToString();
                string food = this.food.ToString();

                using (StreamWriter streamWriter = new StreamWriter(pathBeerFoodMoney))
                {
                    streamWriter.Flush();
                    streamWriter.WriteLine(gold);
                    streamWriter.WriteLine(beer);
                    streamWriter.WriteLine(food);
                }

                this.Close();
            }
        }
    }
}
