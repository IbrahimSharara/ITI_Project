namespace El_Tamayez.Repository;

using El_Tamayez.Models;
public interface IPostRepository
{
    List<Post> GetAllPosts();
    int DeletePost(int id);
    int Insert(Post post);
}
