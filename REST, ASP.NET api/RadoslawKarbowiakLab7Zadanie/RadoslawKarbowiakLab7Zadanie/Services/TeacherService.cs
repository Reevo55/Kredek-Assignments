using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadoslawKarbowiakLab7Zadanie.Models;

namespace RadoslawKarbowiakLab7Zadanie.Services
{
    public class TeacherService : ITeacherService
    {
        SchoolDatabase schoolDS = new SchoolDatabase();
        /// <summary>
        /// Usuniecie nauczyciela
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Teacher teacher, int id)
        {
            schoolDS.DeleteTeacher(id);
            return true;
        }
        /// <summary>
        /// Pobranie nauczycieli
        /// </summary>
        /// <returns></returns>
        public List<Teacher> Get()
        {
            return schoolDS.GetTeachers();
        }
        /// <summary>
        /// Dodanie nauczyciela
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public int Post(Teacher teacher)
        {
            schoolDS.PutTeacher(teacher);
            return 0;
        }
        /// <summary>
        /// Update nauczyciela
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Put(Teacher teacher, int id)
        {
            schoolDS.EditTeacher(teacher, id);

            return true;
        }
    }
}
