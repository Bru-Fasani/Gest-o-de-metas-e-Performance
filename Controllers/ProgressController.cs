using Gestão_de_metas_e_Performance.Models;
using Gestão_de_metas_e_Performance.Controllers;
using Gestão_de_metas_e_Performance.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Gestão_de_metas_e_Performance.Controllers
{
    public class ProgressController : ControllerBase
    {
        [HttpGet("{IdProgress}")]
        public ActionResult<ProgressDTO> GetProgressByMetaId(int metaId)
        {
            return Ok();
        }

        [HttpPost] //não esta aparecendo no swagger
        public ActionResult<ProgressDTO> CreateProgress(Progress progress)
        {
            return Ok();
        }

        [HttpPut("{IdProgress}")]
        public ActionResult<ProgressDTO> UpdateProgress(int metaId, Progress progress)
        {
            return Ok();
        }

        [HttpDelete("{IdProgress}")]
        public ActionResult<ProgressDTO> DeleteProgress(int metaId)
        {
            return Ok();
        }





    }
}
