using AutoMapper;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.BookModels;
using BookLibraryApi.Repositories.BookReposittory;
using BookLibraryApi.ResourceParameters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("/api")]
    public class SecarchController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public SecarchController(
            IBookRepository bookRepository,
            IMapper mapper
            )
        {
            _bookRepository = bookRepository ??
                throw new ArgumentNullException(nameof(bookRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetBooks(
            [FromQuery] BookResourceParameters parameters)
        {
            var Books = await _bookRepository.GetBooks(Guid.Empty, parameters);

            if (Books == null)
            {
                return NotFound();
            }
            var BooksToReturn = _mapper.Map<IEnumerable<BookDto>>(Books).ShapeData(parameters.Fields);
            return Ok(BooksToReturn);
        }

    }
}
