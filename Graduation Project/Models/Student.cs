using System.ComponentModel.DataAnnotations.Schema;

namespace El_Tamayez.Models
{
    public class Student
    {
        public Student()
        {
            Posts = new List<Post>();
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public StudentGender Gender { get; set; }
        public string Picture { get; set; }
        public Year Year { get; set; }
        public virtual List<Post> Posts { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
    public enum Year
    {
        First,
        Second,
        Third
    }
    public enum StudentGender
    {
        Male,
        Female
    }
}
