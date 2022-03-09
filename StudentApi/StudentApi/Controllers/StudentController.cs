using System;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Interfaces;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly IStudent _repo;
        public StudentController(IStudent repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            _repo.Add(student);
            return Ok(student);
        }


        [HttpPost]
        public ActionResult Edit(Student student)
        {
            _repo.Edit(student);
            return Ok(student);
        }


        [HttpPost]
        public ActionResult Delete(int Id)
        {
            return Ok(_repo.Delete(Id));
            
        }

        [HttpGet]
        public ActionResult FindById(int Id)
        {
           return Ok( _repo.FindById(Id));
        }


        [HttpGet]
        public ActionResult GetAllStudents()
        {
            return Ok(_repo.GetAll());
        }

    }
}
