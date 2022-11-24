using System.ComponentModel.DataAnnotations.Schema;

namespace El_Tamayez.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        public DateTime PostTime { get; set; }
        public int LikeCounter { get; set; }
        public string Content { get; set; }
        public string? Picture { get; set; }

        public virtual List<Comment> Comments { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }


        [ForeignKey("Admin")]
        public int? AdminId { get; set; }
        public Admin? Admin { get; set; }


        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }

}
