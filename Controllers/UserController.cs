using Gestão_de_metas_e_Performance.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Gestão_de_metas_e_Performance.DBContext;
using Microsoft.AspNetCore.Http.HttpResults;


namespace Gestão_de_metas_e_Performance.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet("{Id}")]
        public IActionResult GetUserById(int Id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
           return Ok(user);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateUser(int Id, User user)
        {
            return Ok(user);
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteUser(int Id)
        {
            return Ok();
        }

    }        
}
