using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab7Zadanie.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public int Salary { get; set; }

        public Teacher(int id, string firstName, string secondName, int salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Salary = salary;
        }

        public void RaiseSalary(int amountOfRaise)
        {
            Salary += amountOfRaise;
        }
    }
}
