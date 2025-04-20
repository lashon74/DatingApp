using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]// /api/user
    //New way of using dbcontext
    public class UsersController(DataContext context) : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUser()
        {
            var users = context.Users.ToList();
            return users;
        }
        //{} is type safty 
         [HttpGet("{id}")] // /api/user/3
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}