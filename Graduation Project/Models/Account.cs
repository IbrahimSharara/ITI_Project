using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace El_Tamayez.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public UserType Type { get; set; }
        [ForeignKey("Student")]
        public int? Student_Id { get; set; }
        public Student? Student { get; set; }
        [ForeignKey("Teacher")]
        public int? Teacher_Id { get; set; }
        public Teacher? Teacher { get; set; }
    }
    public enum UserType
    {
        Student,
        Teacher
    }
}
