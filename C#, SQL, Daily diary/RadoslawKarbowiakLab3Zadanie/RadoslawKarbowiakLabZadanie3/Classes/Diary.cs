using RadoslawKarbowiakLabZadanie3.Classes.UserRelated;
using RadoslawKarbowiakLabZadanie3.Classes.TaskRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter;

namespace RadoslawKarbowiakLabZadanie3.Classes
{
    public class Diary
    {
        private DateTime chosenDay = DateTime.Today;
        private User user;
        private List<TaskRelated.Task> dayTasks;
        private string sChosenDay;

        public Diary(User user)
        {
            this.user = user;
            this.sChosenDay = chosenDay.ToString("MMMM dd, yyyy");
            SQLConnector sQLConnector = new SQLConnector();
            this.dayTasks = sQLConnector.ReturnListOfUserTasks(user, chosenDay);
        }

        public Diary()
        {
            user = new User("Default");
            SQLConnector sQLConnector = new SQLConnector();
            this.dayTasks = sQLConnector.ReturnListOfUserTasks(user, chosenDay);
            this.sChosenDay = chosenDay.ToString("MMMM dd, yyyy");
        }

        public TaskRelated.Task CreateTask(string description, string importantence)
        {
            TaskRelated.Task task = new TaskRelated.Task(description, importantence, false);

            return task;
        }
        /// <summary>
        /// dodawanie task do listy tasks
        /// </summary>
        /// <param name="taskToAdd"></param>
        /// <returns></returns>
        public bool addTaskToDayTasks(TaskRelated.Task taskToAdd)
        {
            dayTasks.Add(taskToAdd);
            return true;
        }
        /// <summary>
        /// dzien do przodu
        /// </summary>
        /// <returns></returns>
        public bool DayFoward()
        {
            this.chosenDay = this.chosenDay.AddDays(1);
            this.sChosenDay = chosenDay.ToString("dd/MM/yyyy");

            return true;
        }
        /// <summary>
        /// dzien do tylu
        /// </summary>
        /// <returns></returns>
        public bool DayBackwards()
        {
            this.chosenDay = this.chosenDay.AddDays(-1);
            this.sChosenDay = chosenDay.ToString("dd/MM/yyyy");

            return true;
        }
        /// <summary>
        /// aktualizacja tablicy tasks
        /// </summary>
        public void updateTaskTable()
        {
            SQLConnector sQLConnector = new SQLConnector();
            this.dayTasks = sQLConnector.ReturnListOfUserTasks(user, chosenDay);
        }
        public string MySChosenDay { get; set; }
        public List<TaskRelated.Task> DayTasks { get { return dayTasks; } set { dayTasks = value; } }
        public User MyUser { get; set; }
        public DateTime Date{ get { return chosenDay; } set { chosenDay = value;} }
    }
}
