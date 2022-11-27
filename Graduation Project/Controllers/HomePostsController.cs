using El_Tamayez.Models;
using El_Tamayez.Repository;
using El_Tamayez.ViewModels;
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
