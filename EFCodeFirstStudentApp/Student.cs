using System;
using System.ComponentModel.DataAnnotations;

namespace EfCodeFirstStudentApp
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        public DateTime EnrolledOn { get; set; }
    }
}
