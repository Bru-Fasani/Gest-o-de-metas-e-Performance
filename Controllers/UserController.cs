using Gestão_de_metas_e_Performance.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Gestão_de_metas_e_Performance.DBContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Gestão_de_metas_e_Performance.DTOs;


namespace Gestão_de_metas_e_Performance.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet("{Id}")]
        public ActionResult<UserDTO> GetUserById(int Id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<UserDTO> CreateUser(User user)
        {
           return Ok(user);
        }

        [HttpPut("{Id}")]
        public ActionResult<UserDTO> UpdateUser(int Id, User user)
        {
            return Ok(user);
        }

        [HttpDelete("{Id}")]
        public ActionResult<UserDTO> DeleteUser(int Id)
        {
            return Ok();
        }

    }        
}
