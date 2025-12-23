using Microsoft.AspNetCore.Mvc;
using Gestão_de_metas_e_Performance.Models;
using Gestão_de_metas_e_Performance.DBContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Gestão_de_metas_e_Performance.DTOs;

namespace Gestão_de_metas_e_Performance.Controllers
{
    public class MetasController : ControllerBase
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

            /*[HttpGet("{IdMeta}")]
            public ActionResult<MetaDTO> GetGoalById(int IdMeta)
            {
                return Ok();
            }
            */

            [HttpPost]// não aparece no swagger
            public ActionResult<MetaDTO> CreateMeta(Meta meta)
            {
                return Ok();
            }

            [HttpPut("{IdMeta}")]
            public ActionResult<MetaDTO> UpdateMeta(int IdMeta)
            {
                return Ok();
            }

            [HttpDelete] // não aparece no swagger
            public ActionResult<MetaDTO> DeleteMeta(Meta meta)
            {
                return Ok();
            }


        }
        


    }
}
