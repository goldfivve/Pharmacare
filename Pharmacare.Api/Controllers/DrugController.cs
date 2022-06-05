using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacare.Api.Extensions;
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
        public async Task<ActionResult<IEnumerable<DrugDto>>> GetItems()
        {
            try
            {
                var drugs = await _drugRepository.GetItems();
                var drugCategories = await _drugRepository.GetCategories();
                var activeSubstances = await _drugRepository.GetActiveSubstances();

                if (drugs == null || drugCategories == null || activeSubstances == null)
                {
                    return NotFound();
                }
                else
                {
                    var drugDtos = drugs.ConvertToDto(drugCategories, activeSubstances);
                    return Ok(drugDtos);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DrugDto>> GetItem(int id)
        {
            try
            {
                var drug = await _drugRepository.GetDrugById(id);

                if (drug == null)
                {
                    return BadRequest();
                }
                else
                {
                    var category = await _drugRepository.GetCategoryById(drug.CategoryId);
                    var activeSubstance = await _drugRepository.GetActiveSubstanceById(drug.ActiveSubstanceId);

                    var drugDto = drug.ConvertToDto(category, activeSubstance);

                    return Ok(drugDto);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


    }
}
