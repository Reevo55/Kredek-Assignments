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
    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        /// <summary>
        /// Komentarze w tym pliku są zbędne, nazwy funkcji wyrażają je wystarczająco, głębsze komentarze są w innych plikach
        /// </summary>
        
        private ITeacherService teacherService;


        public TeacherController()
        {
            teacherService = new TeacherService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var teachers = teacherService.Get();

            return Ok(teachers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Teacher teacher)
        {
            teacherService.Post(teacher);

            return Ok();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromBody] Teacher teacher, [FromRoute] int id)
        {
            if (teacherService.Delete(teacher, id) == true) return Ok();
            else return Conflict("Error");
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Teacher teacher, [FromRoute] int id)
        {
            if (teacherService.Put(teacher, id) == true) return Ok();
            else return Conflict("Error");
        }
    }
}