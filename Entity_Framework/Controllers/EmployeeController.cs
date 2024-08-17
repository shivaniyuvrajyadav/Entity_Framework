using Entity_Framework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public EmployeeController(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }

        [HttpGet("")]

        public IActionResult GetResult()
        {
            var res = this.appDbContext.Employees.ToList();
            return Ok(res);
        }
    }
}
