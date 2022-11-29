namespace El_Tamayez.Repository;

using El_Tamayez.Models;
using El_Tamayez.ViewModels;

public interface IPostRepository
{
    List<Post> GetAllPosts();
    List<Post> GetAllPostsForAdmin();
    List<GetPost> GetPostForAdmin();
    List<GetPost> GetPostWithOwner();
    int DeletePost(int id);
    int Insert(Post post);
}
