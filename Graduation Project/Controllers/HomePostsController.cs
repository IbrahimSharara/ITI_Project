using El_Tamayez.Models;
<<<<<<< HEAD
 
=======
using El_Tamayez.Repository;
using El_Tamayez.ViewModels;
>>>>>>> ca754856c75128b1668ee6b51bd7ffaef5f7dc6e
using Microsoft.AspNetCore.Mvc;

namespace El_Tamayez.Controllers
{
    public class HomePostsController : Controller
    {
        IPostRepository post;
        public HomePostsController( IPostRepository _post)
        {
            post= _post;
        }
        public IActionResult Index()
        {
            List<GetPost> posts = post.GetPostForAdmin();
            return View(posts);
        }


    }
}
