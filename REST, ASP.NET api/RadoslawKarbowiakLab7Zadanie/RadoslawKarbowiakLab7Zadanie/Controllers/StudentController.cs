using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadoslawKarbowiakLab7Zadanie.Models;
using RadoslawKarbowiakLab7Zadanie.Services;

namespace RadoslawKarbowiakLab7Zadanie.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService studentService;
        /// <summary>
        /// Komentarze w tym pliku są zbędne, nazwy funkcji wyrażają je wystarczająco, głębsze komentarze są w innych plikach
        /// </summary>

        public StudentController()
        {
            studentService = new StudentService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = studentService.Get();

            return Ok(students);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            studentService.Post(student);

            return Ok();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromBody] Student student, [FromRoute] int id)
        {
            if (studentService.Delete(student, id) == true) return Ok();
            else return Conflict("Error");
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Student student, [FromRoute] int id)
        {
            if (studentService.Put(student, id) == true) return Ok(); 
            else return Conflict("Error!");
        }
    }
}