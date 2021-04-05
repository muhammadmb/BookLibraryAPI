using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.AuthorsModels;
using BookLibraryApi.Repositories.AuthorRepository;
using BookLibraryApi.ResourceParameters;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [EnableCors("demoPolicy")]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IPropertyCheckerService _propertyChecker;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, IPropertyCheckerService propertyChecker, IMapper mapper)
        {
            _authorRepository = authorRepository ??
                throw new ArgumentNullException(nameof(authorRepository));
            _propertyChecker = propertyChecker ??
                throw new ArgumentNullException(nameof(propertyChecker));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetAuthors")]
        [HttpHead()]
        public async Task<IActionResult> GetAuthors(
            [FromQuery] AuthorResourcesParameters parameters
            )
        {
            if (!_propertyChecker.TypeHasProperties<AuthorDto>(parameters.Fields))
            {
                return NotFound();
            }

            var authorsFromRepo = await _authorRepository.GetAuthors(parameters);

            if (authorsFromRepo == null)
            {
                return NotFound();
            }

            var authorsToReturn = _mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo).ShapeData(parameters.Fields);

            return Ok(authorsToReturn);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        [HttpHead("{id}")]
        public async Task<IActionResult> GetAuthor(Guid id, string fields)
        {
            if (!_propertyChecker.TypeHasProperties<AuthorDto>(fields))
            {
                return NotFound();
            }

            var authorFromRepo = await _authorRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            var authorToReturn = _mapper.Map<AuthorDto>(authorFromRepo).ShapeData(fields);

            return Ok(authorToReturn);
        }

        [HttpPost()]
        public async Task<IActionResult> AddAuthor(AuthorCreation authorCreation)
        {
            if (authorCreation == null)
            {
                return NotFound();
            }

            var author = _mapper.Map<Author>(authorCreation);

            _authorRepository.CreateAuthor(author);
            await _authorRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetAuthor",
                new { author.Id },
                $"{author.Name} is added successfuly");

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(Guid id, UpdateAuthor updateAuthor)
        {
            if (updateAuthor == null)
            {
                return NotFound();
            }

            var authorFromRepo = await _authorRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(updateAuthor, authorFromRepo);
            _authorRepository.Update(authorFromRepo);
            await _authorRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PartialUpdateAuthor(
            Guid id,
            JsonPatchDocument<UpdateAuthor> patchDocument)
        {
            if (patchDocument == null)
            {
                return NotFound();
            }

            var authorFromRepo = await _authorRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            var author = _mapper.Map<UpdateAuthor>(authorFromRepo);

            patchDocument.ApplyTo(author, ModelState);

            if (!TryValidateModel(author))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(author, authorFromRepo);

            _authorRepository.Update(authorFromRepo);

            await _authorRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            _authorRepository.Delete(id);
            await _authorRepository.SaveChangesAsync();
            return (NoContent());
        }

        [HttpOptions()]
        public IActionResult GetAuthorsOptions()
        {
            Response.Headers.Add("Allow", "Get, Post, Head, Options");
            return Ok();
        }

        [HttpOptions("{id}")]
        public IActionResult GetAuthorOptions()
        {
            Response.Headers.Add("Allow", "Get, Post, Put, patch, Head, Options");
            return Ok();
        }

    }
}
