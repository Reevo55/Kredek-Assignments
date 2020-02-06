using RadoslawKarbowiakLab7Zadanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab7Zadanie
{
    interface ITeacherService
    {
        List<Teacher> Get();
        int Post(Teacher teacher);
        bool Put(Teacher teacher, int id);
        bool Delete(Teacher teacher, int id);
    }
}
