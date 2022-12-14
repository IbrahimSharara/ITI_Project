namespace Graduation_Project.Repository;
using Graduation_Project.Models;
using Graduation_Project.ViewModels;

public class PostRepository : IPostRepository
{
    CenterDBContext db;
    public PostRepository(CenterDBContext _db)
    {
        db = _db;
    }
    public List<Post> GetAllPosts()
    {
        return db.Posts.ToList();
    }
    public List<Post> GetAllPostsForAdmin()
    {
        return db.Posts.Where(n => n.GroupId == 0 ).ToList();
    }
    public List<GetPost> GetPostForAdmin()
    {
        //@ get all posts which havw been writen by admin
        List<Post> posts = this.GetAllPostsForAdmin();
        // define posts which will be show at HomePost Page
        List<GetPost> postWithInfo = new List<GetPost>();
        // fill post with admin information
        foreach (var item in posts)
        {
            GetPost p = new GetPost();
            p.PostMakerId = db.Admins.Where(n => n.Id == item.AdminId).Select(n => n.Id).FirstOrDefault();
            p.likes = item.LikeCounter;
            p.PostMakerName = db.Admins.Where(n => n.Id == item.AdminId).Select(n => n.Name).FirstOrDefault();
            p.PostDate = item.PostTime;
            p.PostMakerImage = null;
            p.Content = item.Content;
            postWithInfo.Add(p);
        }
        return postWithInfo;
    }

    public List<GetPost> GetPostWithOwner()
    {
        List<Post> posts = this.GetAllPosts();
        List<GetPost> postWithInfo = new List<GetPost>();
        foreach (var item in posts)
        {
            /*if (item.AdminId != null)
            {
                GetPost p = new GetPost();
                p.PostMakerId = db.Admins.Where(n => n.Id == item.AdminId).Select(n => n.Id).FirstOrDefault();
                p.likes = item.LikeCounter;
                p.PostMakerName = db.Admins.Where(n => n.Id == item.AdminId).Select(n => n.Name).FirstOrDefault();
                p.PostDate = item.PostTime;
                p.PostMakerImage = null;
                p.Content = item.Content;
                postWithInfo.Add(p);
            }*/
            //else if (item.StudentId != null)
            if (item.StudentId != null)
            {
                GetPost p = new GetPost();
                p.PostMakerId = db.Students.Where(n => n.Id == item.StudentId).Select(n => n.Id).FirstOrDefault();
                p.likes = item.LikeCounter;
                p.PostMakerName = db.Students.Where(n => n.Id == item.StudentId).Select(n => n.FirstName + " " + n.LastName).FirstOrDefault();
                p.PostDate = item.PostTime;
                p.PostMakerImage = db.Students.Where(n => n.Id == item.StudentId).Select(n => n.Picture).FirstOrDefault();
                p.Content = item.Content;
                postWithInfo.Add(p);
            }

            else if(item.TeacherId != null)
            {
                GetPost p = new GetPost();
                p.PostMakerId = db.Teachers.Where(n => n.Id == item.TeacherId).Select(n => n.Id).FirstOrDefault();
                p.likes = item.LikeCounter;
                p.PostMakerName = db.Teachers.Where(n => n.Id == item.TeacherId).Select(n => n.FirstName + " " + n.LastName).FirstOrDefault();
                p.PostDate = item.PostTime;
                p.PostMakerImage = db.Teachers.Where(n => n.Id == item.TeacherId).Select(n => n.Picture).FirstOrDefault(); ;
                p.Content = item.Content;
                postWithInfo.Add(p);
            }
        }
        return postWithInfo;
    }

    public int DeletePost(int id)
    {
        Post p = db.Posts.SingleOrDefault(n => n.Id == id);
        db.Posts.Remove(p);
        return db.SaveChanges();
    }

    public int Insert(Post post)
    {
        db.Posts.Add(post);
        return db.SaveChanges();
    }


}
