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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// przycisk logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            SQLConnector sqlConnector = new SQLConnector();
            if (sqlConnector.SignInDTD(login, password))
            {
                FormDiary formDiary = new FormDiary();
                formDiary.user = new Classes.UserRelated.User(login);
                formDiary.SetLabelName(login);
                this.Hide();
                formDiary.OptimizeFormDiary();
                formDiary.Show();
            }
            else MessageBox.Show("Ups, coś poszło nie tak! Złe dane logowania!");
        }

        /// <summary>
        /// przycisk rejestracji nowego uzytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();

            this.Hide();
            formRegister.formMain = this;
            formRegister.Show();
        }
    }
}
