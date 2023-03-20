using Jwt_Web_Token.Constans;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_Web_Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles =("Administrador"))]

        public IActionResult Get()
        {
            var listEmployee = EmployeeConstants.Employees; 
            return Ok(listEmployee);    
        }
    }
}
