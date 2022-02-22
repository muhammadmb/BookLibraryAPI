using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.SuggesstionModels;
using BookLibraryApi.Repositories.SuggesstionRepository;
using BookLibraryApi.ResourceParameters;
using BookLibraryApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [Route("api/Suggesstions")]
    [ApiController]
    [EnableCors("demoPolicy")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master, Editor")]
    public class SuggesstionController : ControllerBase
    {

        private readonly ISuggesstionRepository _suggesstionRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyCheckerService _propertyCheckerService;

        public SuggesstionController(
            ISuggesstionRepository suggesstionRepository,
            IMapper mapper,
            IPropertyCheckerService propertyCheckerService)
        {
            _suggesstionRepository = suggesstionRepository ??
                throw new ArgumentNullException(nameof(suggesstionRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));
        }

        [HttpGet]
        public async Task<IActionResult> GetSuggesstions(
            [FromQuery] ResourcesParameters parameters
            )
        {
            if (!_propertyCheckerService.TypeHasProperties<Suggesstion>(parameters.Fields))
            {
                return BadRequest();
            }

            var suggesstions = await _suggesstionRepository.GetSuggesstions(parameters);

            if (suggesstions == null)
            {
                return NotFound();
            }

            var paginationMetadata = new
            {
                pageSize = suggesstions.PageSize,
                currentPage = suggesstions.CurrentPage,
                hasNext = suggesstions.HasNext,
                hasPrevious = suggesstions.HasPrevious
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            return Ok(suggesstions.ShapeData(parameters.Fields));
        }

        [HttpGet("{id}", Name = "GetSuggesstion")]
        public async Task<IActionResult> GetSuggesstion(Guid id, [FromQuery] string fileds)
        {
            if (!_propertyCheckerService.TypeHasProperties<Suggesstion>(fileds))
            {
                return BadRequest();
            }

            var suggesstion = await _suggesstionRepository.GetSuggesstion(id);

            if (suggesstion == null)
            {
                return NotFound();
            }

            return Ok(suggesstion.ShapeData(fileds));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateSuggesstion([FromBody] SuggesstionCreationDto creationDto)
        {
            if (creationDto == null)
            {
                throw new ArgumentNullException(nameof(creationDto));
            }

            var suggesstion = _mapper.Map<Suggesstion>(creationDto);
            _suggesstionRepository.Create(suggesstion);
            await _suggesstionRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetSuggesstion",
                new { suggesstion.Id },
                "suggesstion is added successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, SuggesstionUpdateDto updateDto)
        {
            if (updateDto == null)
            {
                throw new ArgumentNullException(nameof(updateDto));
            }

            var suggesstionFromRepo = await _suggesstionRepository.GetSuggesstion(id);

            if (suggesstionFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(updateDto, suggesstionFromRepo);
            _suggesstionRepository.Update(suggesstionFromRepo);
            await _suggesstionRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PartialUpdate(Guid id, JsonPatchDocument<SuggesstionUpdateDto> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }

            var suggesstionFromRepo = await _suggesstionRepository.GetSuggesstion(id);

            if (suggesstionFromRepo == null)
            {
                return NotFound();
            }

            var suggesstion = _mapper.Map<SuggesstionUpdateDto>(suggesstionFromRepo);

            patchDocument.ApplyTo(suggesstion, ModelState);

            if (!TryValidateModel(suggesstion))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(suggesstion, suggesstionFromRepo);
            _suggesstionRepository.Update(suggesstionFromRepo);
            await _suggesstionRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master")]
        public async Task<IActionResult> Delete(Guid id)
        {
            _suggesstionRepository.Delete(id);
            await _suggesstionRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
