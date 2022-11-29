using Graduation_Project.Models;
using Graduation_Project.Repository;
 
using Graduation_Project.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project.Controllers
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
