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
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [Route("api/Suggestions")]
    [ApiController]
    [EnableCors("demoPolicy")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master, Editor")]
    public class SuggestionController : ControllerBase
    {

        private readonly ISuggestionRepository _suggesstionRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyCheckerService _propertyCheckerService;

        public SuggestionController(
            ISuggestionRepository suggesstionRepository,
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
        public async Task<IActionResult> GetSuggestions(
            [FromQuery] ResourcesParameters parameters
            )
        {
            if (!_propertyCheckerService.TypeHasProperties<Suggestion>(parameters.Fields))
            {
                return BadRequest();
            }

            var Suggestions = await _suggesstionRepository.GetSuggestions(parameters);

            if (Suggestions == null)
            {
                return NotFound();
            }

            var paginationMetadata = new
            {
                pageSize = Suggestions.PageSize,
                currentPage = Suggestions.CurrentPage,
                hasNext = Suggestions.HasNext,
                hasPrevious = Suggestions.HasPrevious,
                totalPages = Suggestions.TotalPages,
                totalCount = Suggestions.TotalCount
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            var SuggestionsToReturn = _mapper.Map<IEnumerable<SuggestionDto>>(Suggestions).ShapeData(parameters.Fields);

            return Ok(SuggestionsToReturn);
        }

        [HttpGet("{id}", Name = "GetSuggesstion")]
        public async Task<IActionResult> GetSuggesstion(Guid id, [FromQuery] string fileds)
        {
            if (!_propertyCheckerService.TypeHasProperties<Suggestion>(fileds))
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
        public async Task<IActionResult> CreateSuggesstion([FromBody] SuggestionCreationDto creationDto)
        {
            if (creationDto == null)
            {
                throw new ArgumentNullException(nameof(creationDto));
            }

            var suggesstion = _mapper.Map<Suggestion>(creationDto);
            _suggesstionRepository.Create(suggesstion);
            await _suggesstionRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetSuggesstion",
                new { suggesstion.Id },
                "suggesstion is added successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, SuggestionUpdateDto updateDto)
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
        public async Task<IActionResult> PartialUpdate(Guid id, JsonPatchDocument<SuggestionUpdateDto> patchDocument)
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

            var suggesstion = _mapper.Map<SuggestionUpdateDto>(suggesstionFromRepo);

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
