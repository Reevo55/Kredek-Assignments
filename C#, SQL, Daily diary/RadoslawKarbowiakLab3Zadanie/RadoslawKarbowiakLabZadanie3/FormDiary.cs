using RadoslawKarbowiakLabZadanie3.Classes;
using RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter;
using RadoslawKarbowiakLabZadanie3.Classes.UserRelated;
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
    public partial class FormDiary : Form
    {
        private DateTime dateTime = DateTime.Today;
        public User user;
        private Diary diary;

        public FormDiary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// tutaj dzieja sie wszystkie rzeczy ktore musza wydarzyc sie opdczas inicjacji form diary, ale nie moga byc w konstruktorze
        /// </summary>
        public void OptimizeFormDiary()
        {
            diary = new Diary(user);
            diary.Date = dateTime;
            UpdateTime();
            SQLConnector sQLConnetor = new SQLConnector();
            dataGridViewTasks.DataSource = sQLConnetor.ReturnDataTable(user, diary.Date);
            dataGridViewTasks.Columns["TaskID"].Visible = false;
            dataGridViewTasks.Columns["UserID"].Visible = false;
            dataGridViewTasks.Columns["Date"].Visible = false;
            dataGridViewTasks.Columns["Descr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTasks.Columns["Importance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        /// <summary>
        /// Wyjscie z aplikacji 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
        /// <summary>
        /// zmiana nazwy
        /// </summary>
        /// <param name="name"></param>
        public void SetLabelName(string name)
        {
            labelUserName.Text = name;
        }
        /// <summary>
        /// w lewo data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.dateTime = this.dateTime.AddDays(-1);
            diary.Date = this.dateTime;
            UpdateTime();
        }
        /// <summary>
        /// aktualizacja czasu
        /// </summary>
        private void UpdateTime()
        {
            labelDate.Text = diary.Date.ToString("dd-MM");
            SQLConnector sQLConnetor = new SQLConnector();
            dataGridViewTasks.DataSource = sQLConnetor.ReturnDataTable(user, diary.Date);
        }
        /// <summary>
        /// w prawo czas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.dateTime = this.dateTime.AddDays(1);
            diary.Date = this.dateTime;
            UpdateTime();
        }
        /// <summary>
        /// przycisk do aktualizowania tasks w bazie danych, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewTasks.Rows)
            {
                string descr = item.Cells[1].Value.ToString();
                string importance = item.Cells[2].Value.ToString();
                string date = diary.Date.ToString("yyyy-MM-dd");
                string isDone = item.Cells[3].Value.ToString();
                SQLConnector sQLConnector = new SQLConnector();
                sQLConnector.UpdateTask(descr, importance, date, isDone);

                MessageBox.Show("Zaktualizowano!");
                return;
            }
        }

        /// <summary>
        /// button do dodawania kolejnych task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (checkedListBoxImportance.CheckedItems == null)
            {
                MessageBox.Show("Zaznacz ważność!");
                return;
            }
            Classes.TaskRelated.Task task = new Classes.TaskRelated.Task(textBoxTask.Text.ToString(), checkedListBoxImportance.CheckedItems[0].ToString(), false);

            SQLConnector sQLConnector = new SQLConnector();
            sQLConnector.InsertTaskIntoTasks(task, user, diary);
            diary.addTaskToDayTasks(task);

            SQLConnector sQLConnetor = new SQLConnector();
            dataGridViewTasks.DataSource = sQLConnetor.ReturnDataTable(user, diary.Date);

            textBoxTask.Text = "";
            foreach (int i in checkedListBoxImportance.CheckedIndices)
            {
                checkedListBoxImportance.SetItemCheckState(i, CheckState.Unchecked);
            }
            MessageBox.Show("Zadanie dodane!");
        }
        /// <summary>
        /// usuwanie zadania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewTasks.SelectedRows)
            {
                string descr = item.Cells[1].Value.ToString();
                string importance = item.Cells[2].Value.ToString();
                string date = diary.Date.ToString("yyyy-MM-dd");
                SQLConnector sQLConnector = new SQLConnector();
                sQLConnector.DeleteTaskFromDatabase(descr, importance, date);

                dataGridViewTasks.Rows.RemoveAt(item.Index);
                return;
            }
        }
    }
}
