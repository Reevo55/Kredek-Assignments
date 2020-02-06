using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace RadoslawKarbowiakLab7Zadanie.Tests
{
    public class SchoolDatabaseShould
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-1000)]
        [InlineData(9999)]
        public void deleteCheck(int id)
        {
            SchoolDatabase schoolDatabase = new SchoolDatabase();

            Assert.False(schoolDatabase.DeleteStudent(id));
        }

        [Fact]
        public void deleteCheckFact()
        {
            SchoolDatabase schoolDatabase = new SchoolDatabase();

            Assert.False(schoolDatabase.DeleteStudent(99990));
        }

        [Fact]
        public void studentListCheckFact()
        {
            SchoolDatabase schoolDatabase = new SchoolDatabase();

            List<Student> listOfStudents = schoolDatabase.GetStudents();

            Assert.NotEmpty(listOfStudents);
        }

        [Fact]
        public void studentPutFact()
        {
            SchoolDatabase schoolDatabase = new SchoolDatabase();

            Student student = new Student(10, "Krystian", "Dab", 5);
           
            Assert.True(schoolDatabase.PutStudent(student));
        }


    }
}
