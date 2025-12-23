using Gestão_de_metas_e_Performance.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Gestão_de_metas_e_Performance.DBContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Gestão_de_metas_e_Performance.DTOs;


namespace Gestão_de_metas_e_Performance.Controllers
{
    public class UserController : ControllerBase
    {
        [ApiController]
        [Route("api/[controller]")]
        public class TarefasController : ControllerBase
        {
            private readonly AppDbContext _context;

            public TarefasController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet("{Id}")]
            public ActionResult<UserDTO> GetUserById(int UserId)
            {
                var user = _context.Users.Find(UserId);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok();
            }
            

            [HttpPost]
            public ActionResult<UserDTO> CreateUser(User user)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return Ok();
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
}
