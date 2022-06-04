using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacare.Api.Repositories.Contracts;
using Pharmacare.Models.Dtos;

namespace Pharmacare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugController : ControllerBase
    {
        private readonly IDrugRepository _drugRepository;

        public DrugController(IDrugRepository drugRepository)
        {
            _drugRepository = drugRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DrugDto>>>
    }
}
