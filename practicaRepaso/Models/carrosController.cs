using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practicaRepaso.Models;

namespace practicaRepaso.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class carrosController : ControllerBase
    {
        private readonly carrosContext _carrosContext;
        public carrosController(carrosContext carrosContext)
        {
            _carrosContext = carrosContext;
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult Get()
        {
            List<carros> listCarros = (from e in _carrosContext.carros select e).ToList();

            if (listCarros.Count == 0)
            {
                return NotFound();
            }
            return Ok(listCarros);
        }
    }
}
