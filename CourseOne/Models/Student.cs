using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseOne.Models
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PhoneNumber { get; set; }
    }
}