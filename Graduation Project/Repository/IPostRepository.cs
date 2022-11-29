namespace Graduation_Project.Repository;

using Graduation_Project.Models;
public interface IPostRepository
{
    List<Post> GetAllPosts();
    int DeletePost(int id);
    int Insert(Post post);
}
