using Microsoft.IdentityModel.Protocols;
using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab7Zadanie
{
    public class SchoolDatabase
    {
        /// <summary>
        /// Connection string z poziomu klasy ponieważ nie wiedziałem jak dodać go poprawnie do projektu w asp.net, dodatkowo miałem z nim problemy
        /// </summary>
        private string connectionString = "Server=LAPTOP-BUM997PE\\RADEKSQL;Database=School;Trusted_Connection=True;MultipleActiveResultSets=true";

        public SqlCommand QuerySql { get; set; }

        /// <summary>
        /// zwraca listę nauczycieli
        /// </summary>
        /// <returns></returns>
        public List<Teacher> GetTeachers()
        {
            string query = "SELECT * FROM Teachers"; // Zapytanie

            List<Teacher> returnList = new List<Teacher>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                using (SqlDataReader sqlDataReader = QuerySql.ExecuteReader())
                    try
                    {
                        while (sqlDataReader.Read())
                        {
                            int id = 0;
                            string fn = "";
                            string sn = "";
                            int salary = 0;

                            id = Int32.Parse(sqlDataReader["id"].ToString());
                            fn = sqlDataReader["firstName"].ToString();
                            sn = sqlDataReader["secondName"].ToString();
                            salary = Int32.Parse(sqlDataReader["salary"].ToString());

                            returnList.Add(new Teacher(id, fn, sn, salary));
                        }
                    }
                    finally { connection.Close(); }
            }

            return returnList;
        }
        /// <summary>
        /// dodanie nauczyciela do bazy danych
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public bool PutTeacher(Teacher teacher)
        {
            string query = "INSERT INTO Teachers (firstName, secondName, salary) VALUES(@firstName, @secondName, @salary)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@firstName", teacher.FirstName));
                QuerySql.Parameters.Add(new SqlParameter("@secondName", teacher.SecondName));
                QuerySql.Parameters.Add(new SqlParameter("@salary", teacher.Salary));

                QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }
        /// <summary>
        /// edycja nauczyciela po ID
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EditTeacher(Teacher teacher, int id)
        {
            string query = "UPDATE Teachers SET firstName = @firstName, secondName = @secondName, salary = @salary WHERE id = @id";

            int result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@firstName", teacher.FirstName));
                QuerySql.Parameters.Add(new SqlParameter("@secondName", teacher.SecondName));
                QuerySql.Parameters.Add(new SqlParameter("@salary", teacher.Salary));
                QuerySql.Parameters.Add(new SqlParameter("@id", id));

                result = QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            if (result != 0) return true;
            else return false;
        }
        /// <summary>
        /// Usuniecie nauczyciela po ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteTeacher(int id)
        {
            string query = "DELETE FROM Teachers Where id = @teacherId";
            int result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@teacherId", id));

                result = QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            if (result != 0) return true;
            else return false;
        }

        /// <summary>
        /// Pobranie studentow
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudents()
        {
            string query = "SELECT * FROM Students";

            List<Student> returnList = new List<Student>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                using (SqlDataReader sqlDataReader = QuerySql.ExecuteReader())
                    try
                    {
                        while (sqlDataReader.Read())
                        {
                            int id = 0;
                            string fn = "";
                            string sn = "";
                            float avarageGrade = 0;

                            avarageGrade = float.Parse(sqlDataReader["avarageGrade"].ToString(), CultureInfo.InvariantCulture.NumberFormat);

                            fn = sqlDataReader["firstName"].ToString();
                            sn = sqlDataReader["secondName"].ToString();
                            id = Int32.Parse(sqlDataReader["id"].ToString());

                            returnList.Add(new Student(id, fn, sn, avarageGrade));
                        }
                    }
                    finally { connection.Close(); }
            }

            return returnList;
        }
        /// <summary>
        /// dodanie studenta
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool PutStudent(Student student)
        {
            string query = "INSERT INTO Students (firstName, secondName, avarageGrade) VALUES(@firstName, @secondName, @avarageGrade)";

            int result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@firstName", student.FirstName));
                QuerySql.Parameters.Add(new SqlParameter("@secondName", student.SecondName));
                QuerySql.Parameters.Add(new SqlParameter("@avarageGrade", student.AvarageGrade));

                result = QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            if (result != 0) return true;
            else return false;
        }
        /// <summary>
        /// edycja studenta
        /// </summary>
        /// <param name="student"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool EditStudent(Student student, int id)
        {
            string query = "UPDATE Students SET firstName = @firstName, secondName = @secondName, avarageGrade = @AvarageGrade WHERE id = @id";
            int result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@firstName", student.FirstName));
                QuerySql.Parameters.Add(new SqlParameter("@secondName", student.SecondName));
                QuerySql.Parameters.Add(new SqlParameter("@AvarageGrade", student.AvarageGrade));
                QuerySql.Parameters.Add(new SqlParameter("@id", id));

                result = QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            if (result != 0) return true;
            else return false;
        }
        /// <summary>
        /// usuniecie studenta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteStudent(int id)
        {
            string query = "DELETE FROM Students Where id = @studentId";

            int result = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);

                QuerySql.Parameters.Add(new SqlParameter("@studentId", id));

                result = QuerySql.ExecuteNonQuery();

                connection.Close();
            }

            if (result != 0) return true;
            else return false;
        }
    }
}
