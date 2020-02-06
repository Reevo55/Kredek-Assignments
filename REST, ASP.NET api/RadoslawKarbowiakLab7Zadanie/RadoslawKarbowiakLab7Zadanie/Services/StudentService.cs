using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadoslawKarbowiakLab7Zadanie.Models;

namespace RadoslawKarbowiakLab7Zadanie.Services
{
    public class StudentService : IStudentService
    {
        SchoolDatabase schoolDS = new SchoolDatabase();
        /// <summary>
        /// Usuniecie uczniow
        /// </summary>
        /// <param name="student"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Student student, int id)
        {
            if (schoolDS.DeleteStudent(id)) return true;
            else return false;
        }
        /// <summary>
        /// Pobranie wszystkich uczniow
        /// </summary>
        /// <returns></returns>
        public List<Student> Get()
        {
            return schoolDS.GetStudents();
        }
        /// <summary>
        /// Ddoanie ucznia
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int Post(Student student)
        {
            if (schoolDS.PutStudent(student)) return 0;
            return -1;
        }
        /// <summary>
        /// Update ucznia
        /// </summary>
        /// <param name="student"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Student student, int id)
        {
            if (schoolDS.EditStudent(student, id)) return true;
            else return false;
        }
    }
}
