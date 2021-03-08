using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.GenreModels;
using BookLibraryApi.Repositories.GenreRepository;
using BookLibraryApi.ResourceParameters;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("/api/Genres")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IPropertyCheckerService _propertyCheckerService;
        private readonly IMapper _mapper;

        public GenreController(
            IGenreRepository genreRepository,
            IPropertyCheckerService propertyCheckerService,
            IMapper mapper)
        {
            _genreRepository = genreRepository ??
                throw new ArgumentNullException(nameof(genreRepository));
            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetGenres")]
        [HttpHead]
        public async Task<IActionResult> GetGenres([FromQuery] GenreResourcesParameters parameters)
        {
            if (!_propertyCheckerService.TypeHasProperties<GenreDto>(parameters.Fields))
            {
                return NotFound();
            }

            var GenreGromRepo = await _genreRepository.GetGenres(parameters);

            if (GenreGromRepo == null)
            {
                return NotFound();
            }

            var shapedData = _mapper.Map<IEnumerable<GenreDto>>(GenreGromRepo).ShapeData(parameters.Fields);
            return Ok(shapedData);
        }

        [HttpGet("{id}", Name = "GetGenre")]
        [HttpHead("{id}")]
        public async Task<IActionResult> GetGenre(Guid id, string fields)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (!_propertyCheckerService.TypeHasProperties<GenreDto>(fields))
            {
                return NotFound();
            }

            var GenreFromRepo = await _genreRepository.GetGenre(id);

            if (GenreFromRepo == null)
            {
                return NotFound();
            }

            var shapedData = _mapper.Map<GenreDto>(GenreFromRepo).ShapeData(fields);

            return Ok(shapedData);
        }

        [HttpPost()]
        public async Task<IActionResult> Create(GenreCreation genreCreation)
        {
            if (genreCreation == null)
            {
                throw new ArgumentNullException(nameof(genreCreation));
            }

            var CreatedGenre = _mapper.Map<Genre>(genreCreation);

            _genreRepository.CreateGenre(CreatedGenre);

            await _genreRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetGenre",
                new { id = CreatedGenre.Id },
                $"the {genreCreation.GenreName} Genre is successfuly created");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, GenreUpdate genreUpdate)
        {
            if (genreUpdate == null)
            {
                throw new ArgumentNullException(nameof(genreUpdate));
            }

            var genreFromRepo = await _genreRepository.GetGenre(id);

            if (genreFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(genreUpdate, genreFromRepo);
            _genreRepository.UpdateGenre(genreFromRepo);
            await _genreRepository.SaveChangesAsync();
            return NoContent();
        }
        [HttpOptions()]
        public IActionResult GetGenresOptions()
        {
            Response.Headers.Add("Allow", "Get, Post, Head, Options");
            return Ok();
        }

        [HttpOptions("{id}")]
        public IActionResult GetGenreOptions()
        {
            Response.Headers.Add("Allow", "Get, Head, Put, Options");
            return Ok();
        }
    }
}
