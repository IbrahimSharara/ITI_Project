using System.ComponentModel.DataAnnotations.Schema;

namespace El_Tamayez.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SubjectYear Year { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }

    public enum SubjectYear
    {
        First,
        Second,
        Third
    }
}
