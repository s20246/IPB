using IPB.DTO;
using IPB.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneController : ControllerBase
    {
        private readonly TelephoneContext telephoneContext;

        public TelephoneController(TelephoneContext telephoneContext)
        {
            this.telephoneContext = telephoneContext ?? throw new ArgumentNullException(nameof(telephoneContext));
        }

        [HttpGet("telephones")]
        public async Task<ActionResult<IEnumerable<Telephone>>> GetTelephones()
        {
            var res = (from st in telephoneContext.Telephones
                       select st).ToList();

            return Ok(res.Select(o => new TelephoneDTO(o.IdTelephone, o.Brand, o.Model, o.ReleaseDate)));
        }
    }
}
