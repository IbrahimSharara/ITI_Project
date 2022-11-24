using System.ComponentModel.DataAnnotations.Schema;

namespace El_Tamayez.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Posts = new List<Post>();
            Comments= new List<Comment>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public TeacherGender Gender { get; set; }
        public string? Picture { get; set; }
        public virtual List<Post>? Posts { get; set; }

        public virtual List<Comment>? Comments { get; set; }
    }
    public enum TeacherGender
    {
        Male,
        Female
    }
}
