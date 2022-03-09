using System;
using System.Collections.Generic;
using StudentApi.Models;

namespace StudentApi.Interfaces
{
    public interface IStudent
    {
        public Student Add(Student student);
        public Student Edit(Student student);
        public Student FindById(int Id);
        public List<Student> GetAll();
        public bool Delete(int Id);
    }
}
