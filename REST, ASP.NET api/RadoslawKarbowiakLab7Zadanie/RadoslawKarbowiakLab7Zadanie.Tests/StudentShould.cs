using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RadoslawKarbowiakLab7Zadanie.Tests
{
    public class StudentShould
    {
        [Fact]
        public void StudentIsGood()
        {
            Student sut = new Student(5, "Jacek", "Dobosz", (float) 4.5);

            Assert.Equal("Student jest bardzo dobry", sut.IsStudentGood());
        }
    }
}
