namespace Graduation_Project.Repository;

<<<<<<< HEAD
using Graduation_Project.Models;
=======
using El_Tamayez.Models;
using El_Tamayez.ViewModels;

>>>>>>> 68eba0c44bb32fd5f02e09ca216dac8392b2062b
public interface IPostRepository
{
    List<Post> GetAllPosts();
    List<Post> GetAllPostsForAdmin();
    List<GetPost> GetPostForAdmin();
    List<GetPost> GetPostWithOwner();
    int DeletePost(int id);
    int Insert(Post post);
}
