namespace El_Tamayez.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string FatherPhone { get; set; }
        public Gender Gender { get; set; }
        public string Picture { get; set; }
        public Year Year { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }

}
