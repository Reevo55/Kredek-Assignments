using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab7Zadanie.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public float AvarageGrade { get; set; }

        public Student(int id, string firstName, string secondName, float avarageGrade)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.AvarageGrade = avarageGrade;
        }

        public string IsStudentGood()
        {
            if (AvarageGrade >= 4)
            {
                return "Student jest bardzo dobry";
            }
            else
            {
                return "Student nie jest bardzo dobry";
            }
        }
    }
}
