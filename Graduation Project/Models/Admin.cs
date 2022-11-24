namespace El_Tamayez.Models
{
    public class Admin
    {
        public Admin()
        {
            Posts = new List<Post>();
            Comments = new List<Comment>();
            Groups=new List<Group>();
            Subjects = new List<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        //public virtual List<Account> Accounts { get; set; }
    }
}
