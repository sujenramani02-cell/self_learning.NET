
using System.ComponentModel.DataAnnotations;

namespace StudentCourseRegistration.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter student name")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter course")]
        public string Course { get; set; } = string.Empty;

        [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]
        public int Semester { get; set; }
    }
}
