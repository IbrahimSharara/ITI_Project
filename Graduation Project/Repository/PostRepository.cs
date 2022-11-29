namespace Graduation_Project.Repository;
using Graduation_Project.Models;
public class PostRepository : IPostRepository
{
    CenterDBContext db;
    public PostRepository(CenterDBContext _db)
    {
        db=_db;
    }
    public int DeletePost(int id)
    {
        Post p = db.Posts.SingleOrDefault(n => n.Id == id);
        db.Posts.Remove(p);
        return db.SaveChanges();
    }
    public List<Post> GetAllPosts()
    {
        List<Post> p = db.Posts.ToList();
        return p;
    }
    public int Insert(Post post)
    {
        db.Posts.Add(post);
        return db.SaveChanges();
    }
}
