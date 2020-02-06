using RadoslawKarbowiakLabZadanie3.Classes.UserRelated;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadoslawKarbowiakLabZadanie3.Classes.SQLAdapter
{
    public class SQLConnector
    {
        /// <summary>
        /// Configuration manager potrzebuje dodania do referencji system configuration
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionDailyTaskDiary = () => new SqlConnection(ConfigurationManager.ConnectionStrings["DTD"].ConnectionString);

        public SqlCommand QuerySql { get; set; }

        public SQLConnector(){}

        /// <summary>
        /// funkcja do sprawdzenia czy uzytkownik istnieje w bazie danych
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SignInDTD(string userName, string password)
        {
            int valueResault;
            bool isTrue = false;
            string query = "SELECT COUNT(Name) From Users WHERE Name = @Username AND Password = @Password";
            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", userName));
                QuerySql.Parameters.Add(new SqlParameter("@Password", password));
                valueResault = (int)QuerySql.ExecuteScalar();
                if (valueResault > 0) isTrue = true;
                connection.Close();
            }
            return isTrue;
        }
        /// <summary>
        /// funckaj do rejestrowania nowego uzytkownika
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void RegisterNewUser(string login, string password)
        {
            string query = "INSERT INTO Users(Name, Password) VALUES(@name, @password);";
            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@name", login));
                QuerySql.Parameters.Add(new SqlParameter("@password", password));
                QuerySql.ExecuteNonQuery();
                connection.Close();

            }
        }

        /// <summary>
        /// zwraca liste tasks dla danego uzytkownika o danym dniu
        /// </summary>
        /// <param name="user"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<TaskRelated.Task> ReturnListOfUserTasks(User user, DateTime date)
        {
            List<TaskRelated.Task> tasks = new List<TaskRelated.Task>();

            int userID = -1;

            string query = "SELECT * From Users WHERE Name = @Username;";

            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                if (user.userName != null)
                {
                    QuerySql.Parameters.Add(new SqlParameter("@Username", user.userName));
                }
                else QuerySql.Parameters.Add(new SqlParameter("@Username", "Default"));

                using (SqlDataReader sqlDataReader = QuerySql.ExecuteReader())
                {
                    while (sqlDataReader.Read()) userID = (int)sqlDataReader["UserID"];
                }
                connection.Close();
            }

            if (userID == -1) return null;

            string queryTasks = "SELECT * From Tasks WHERE UserID = @UserID AND Date = @Date;";

            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(queryTasks, connection);
                QuerySql.Parameters.Add(new SqlParameter("@UserID", userID));
                string sqlFormattedDate = date.ToString("yyyy-MM-dd");
                QuerySql.Parameters.Add(new SqlParameter("@Date", sqlFormattedDate));

                using (SqlDataReader sqlDataReader = QuerySql.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        string desc = "";
                        string importance = "";
                        string isDone = "";
                        Boolean isDoneBool = false;
                        desc = sqlDataReader["Descr"].ToString();
                        importance = sqlDataReader["Importance"].ToString();
                        isDone = sqlDataReader["IsDone"].ToString();

                        if (isDone == "true") isDoneBool = true;

                        tasks.Add(new TaskRelated.Task(desc, importance, isDoneBool));
                    }

                }
            }

            return tasks;
        }
        /// <summary>
        /// funkcja zwraca id usera
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private int GetUserId(User user)
        {
            int userID = -1;

            string query = "SELECT * From Users WHERE Name = @Username;";

            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                if (user.userName != null)
                {
                    QuerySql.Parameters.Add(new SqlParameter("@Username", user.userName));
                }
                else QuerySql.Parameters.Add(new SqlParameter("@Username", "Default"));

                using (SqlDataReader sqlDataReader = QuerySql.ExecuteReader())
                {
                    while (sqlDataReader.Read()) userID = (int)sqlDataReader["UserID"];
                }
                connection.Close();
            }

            return userID;
        }
        /// <summary>
        /// funkcja zwracajaca datatable wykorzystywana do datagridview
        /// </summary>
        /// <param name="user"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable ReturnDataTable(User user, DateTime date)
        {
            DataTable dataTable = new DataTable();

            int userID = GetUserId(user);

            if (userID == -1) return null;

            string queryTasks = "SELECT * From Tasks WHERE UserID = @UserID AND Date = @Date;";

            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(queryTasks, connection);
                QuerySql.Parameters.Add(new SqlParameter("@UserID", userID));
                string sqlFormattedDate = date.ToString("yyyy-MM-dd");
                QuerySql.Parameters.Add(new SqlParameter("@Date", sqlFormattedDate));

                using (SqlDataAdapter adapter = new SqlDataAdapter(QuerySql))
                {
                    adapter.Fill(dataTable);
                }

            }

            return dataTable;
        }

        /// <summary>
        /// dodanie nowego zadania do bazy danych zadan
        /// </summary>
        /// <param name="task"></param>
        /// <param name="user"></param>
        /// <param name="diary"></param>
        public void InsertTaskIntoTasks(TaskRelated.Task task, User user, Diary diary)
        {
            string query = "INSERT INTO Tasks(Descr, Importance, Date, UserID, IsDone) VALUES (@Descr,@Importance,@Date,@UserID,@IsDone) ;";

            int userID = GetUserId(user);

            if (userID == -1) return;

            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@Descr", task.Description));
                QuerySql.Parameters.Add(new SqlParameter("@Importance", task.Importance));
                string dateString = diary.Date.ToString("yyyy-MM-dd");
                QuerySql.Parameters.Add(new SqlParameter("@Date", dateString));
                QuerySql.Parameters.Add(new SqlParameter("@UserID", userID));
                int bit = 0;
                if (task.Done == true) bit = 1;
                QuerySql.Parameters.Add(new SqlParameter("@IsDone", bit.ToString()));

                QuerySql.ExecuteNonQuery();

                connection.Close();
            }
        }
        /// <summary>
        /// funkcja aktualizacja zadania
        /// </summary>
        /// <param name="description"></param>
        /// <param name="importance"></param>
        /// <param name="date"></param>
        /// <param name="isDone"></param>
        public void UpdateTask(string description, string importance, string date, string isDone)
        {
            int isDoneInt = 1;
            if (isDone.Equals("false")) isDoneInt = 0;
            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                string query = "UPDATE Tasks SET IsDone = @isDone WHERE CONVERT(VARCHAR(150), Descr) = @descr AND Importance = @import AND Date = @date;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@descr", description));
                    command.Parameters.Add(new SqlParameter("@import", importance));
                    command.Parameters.Add(new SqlParameter("@date", date));
                    command.Parameters.Add(new SqlParameter("@isDone", isDoneInt));

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        /// <summary>
        /// funkcja do usuwania zadania z bazy danych
        /// </summary>
        /// <param name="description"></param>
        /// <param name="importance"></param>
        /// <param name="date"></param>
        public void DeleteTaskFromDatabase(string description, string importance, string date)
        {
            using (var connection = dbConnectionDailyTaskDiary())
            {
                connection.Open();
                string query = "DELETE FROM Tasks WHERE CONVERT(VARCHAR(150), Descr) = @descr AND Importance = @import AND Date = @date;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@descr", description));
                    command.Parameters.Add(new SqlParameter("@import", importance));
                    command.Parameters.Add(new SqlParameter("@date", date));

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
