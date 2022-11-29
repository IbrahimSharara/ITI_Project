using Graduation_Project.Models;
using Graduation_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace El_Tamayez.Controllers
{
    public class HomePostsController : Controller
    {
        //IPostRepository post;
        //public HomePostsController( IPostRepository _post)
        public HomePostsController( )
        //{
        {
            //post= _post;
        }
        public IActionResult Index()
        {
            //List<Post> posts = post.GetAllPosts();
            //return View(post);
            return View();
        }
    }
}
