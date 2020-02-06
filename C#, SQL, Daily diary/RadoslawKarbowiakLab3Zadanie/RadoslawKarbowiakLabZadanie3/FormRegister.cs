using RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadoslawKarbowiakLabZadanie3
{
    public partial class FormRegister : Form
    {
        public FormMain formMain;

        public FormRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// przycisk do powrotu do poprzedniej formy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formMain.Show();
            this.Close();
        }

        /// <summary>
        /// Przycisk do rejestracji nowego uzytkownia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxLogin.Text == "")
            {
                MessageBox.Show("Wartosci nie mogą być puste!");
                return;
            }
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            SQLConnector sQLConnector = new SQLConnector();
            sQLConnector.RegisterNewUser(login, password);

            this.Hide();
            this.formMain.Show();
            this.Close();
               
            ;
        }

    }
}
