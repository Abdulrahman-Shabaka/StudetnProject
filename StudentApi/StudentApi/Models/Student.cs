using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
    }
}
