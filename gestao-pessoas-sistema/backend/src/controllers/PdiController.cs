using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace gestao_pessoas_sistema.backend.src.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PdiController : ControllerBase
    {
        private readonly PdiService _pdiService;

        public PdiController(PdiService pdiService)
        {
            _pdiService = pdiService;
        }

        [HttpPost]
        public ActionResult<Pdi> CreatePdi([FromBody] Pdi pdi)
        {
            var createdPdi = _pdiService.AddPdi(pdi);
            return CreatedAtAction(nameof(GetPdis), new { id = createdPdi.Id }, createdPdi);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pdi>> GetPdis()
        {
            var pdis = _pdiService.GetAllPdis();
            return Ok(pdis);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePdi(int id, [FromBody] Pdi pdi)
        {
            if (id != pdi.Id)
            {
                return BadRequest();
            }

            _pdiService.UpdatePdi(pdi);
            return NoContent();
        }
    }
}