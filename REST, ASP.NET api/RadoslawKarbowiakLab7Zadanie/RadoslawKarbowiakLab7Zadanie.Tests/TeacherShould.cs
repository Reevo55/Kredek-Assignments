using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RadoslawKarbowiakLab7Zadanie.Tests
{
    public class TeacherShould
    {
        [Fact]
        public void RaiseSalaryTeacher()
        {
            int salaryStart = 300;

            Teacher sut = new Teacher(99, "Jan", "Długosz", salaryStart);

            int addSalary = 200;

            sut.RaiseSalary(addSalary);

            Assert.Equal(salaryStart + addSalary, sut.Salary);
        }
    }
}
