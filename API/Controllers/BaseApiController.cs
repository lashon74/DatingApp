using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //making this so all over controllers can pull from this one making it less code to write
    [ApiController]
    [Route("api/[controller]")]// /api/user
    public class BaseApiController :ControllerBase
    {
        
    }
}