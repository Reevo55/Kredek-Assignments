using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab7Zadanie.Services
{
    interface IStudentService
    {
        List<Student> Get();
        int Post(Student student);
        bool Put(Student student, int id);
        bool Delete(Student student, int id);
    }
}
