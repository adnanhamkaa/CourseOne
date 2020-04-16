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
        [Required(ErrorMessage = "You can't leave it blank.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "You can't leave it blank.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You can't leave it blank.")]
        [StringLength(15,MinimumLength =4, ErrorMessage = "enter minimum 3 or 15 maximum chars.")]
        [RegularExpression(@"(\S)+", ErrorMessage = "white space is not allowed.")]
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}