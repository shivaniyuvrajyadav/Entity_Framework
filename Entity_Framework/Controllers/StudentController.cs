using Entity_Framework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public StudentController(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }

        [HttpGet("")]
        public IActionResult GetActionResult()
        {
            var result = this.appDbContext.Students.ToList();
            return Ok(result);
        }


    }
}
