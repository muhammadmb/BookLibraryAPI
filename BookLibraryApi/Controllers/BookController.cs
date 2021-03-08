using AutoMapper;
using BookLibraryApi.Models.BookModels;
using BookLibraryApi.Repositories.BookReposittory;
using BookLibraryApi.ResourceParameters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookLibraryApi.Helper;
using EmployeeApi.Services;
using BookLibraryApi.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace BookLibraryApi.Controllers
{
    [ApiController]
    [Route("api/Genres/{GenreId}/Books")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IPropertyCheckerService _propertyCheckerService;
        private readonly IMapper _mapper;

        public BookController(
            IBookRepository bookRepository,
            IPropertyCheckerService propertyCheckerService,
            IMapper mapper)
        {
            _bookRepository = bookRepository ??
                throw new ArgumentNullException(nameof(bookRepository));
            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetBooks")]
        [HttpHead]
        public async Task<IActionResult> GetBooks(Guid GenreId,
            [FromQuery] BookResourceParameters parameters)
        {

            if (!_propertyCheckerService.TypeHasProperties<BookDto>(parameters.Fields))
            {
                return NotFound();
            }

            var Books = await _bookRepository.GetBooks(GenreId, parameters);

            if(Books == null)
            {
                return NotFound();
            }

            var BooksToReturn = _mapper.Map<IEnumerable<BookDto>>(Books).ShapeData(parameters.Fields);
            return Ok(BooksToReturn);
        }

        [HttpGet("{BookId}", Name ="GetBook")]
        [HttpHead("{BookId}")]
        public async Task<IActionResult> GetBook(
            Guid GenreId,
            Guid BookId,
            [FromQuery] string fields)
        {
            var BookFromRepo = await _bookRepository.GetBook(GenreId, BookId);

            if(BookFromRepo == null)
            {
                return NotFound();
            }

            var BookToreturn = _mapper.Map<BookDto>(BookFromRepo).ShapeData(fields);

            return Ok(BookToreturn);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateBook(
            Guid GenreId,
            [FromBody] BookCreation bookCreation)
        {
            var book = _mapper.Map<Book>(bookCreation);
            _bookRepository.Create(GenreId, book);
            await _bookRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetBook",
                new { book.GenreId ,BookId = book.Id },
                $"the {book.BookTitle} is added successfuly"
                );
        }

        [HttpPut("{BookId}")]
        public async Task<IActionResult> UpdateBook(
            Guid GenreId,
            Guid BookId,
            BookUpdate bookUpdate)
        {
            var bookFromRepo = await _bookRepository.GetBook(GenreId, BookId);

            _mapper.Map(bookUpdate,bookFromRepo);
            _bookRepository.Update(bookFromRepo);
            await _bookRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{BookId}")]
        public async Task<IActionResult> PartialUpdate(Guid GenreId, Guid BookId, JsonPatchDocument<BookUpdate> patchDocument)
        {
            var bookFromRepo = await _bookRepository.GetBook(GenreId ,BookId);

            var book = _mapper.Map<BookUpdate>(bookFromRepo);

            patchDocument.ApplyTo(book, ModelState);

            if (!TryValidateModel(book))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(book, bookFromRepo);

            _bookRepository.Update(bookFromRepo);

            await _bookRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpOptions()]
        public IActionResult GetBooksOptions()
        {
            Response.Headers.Add("Allow", "Get, Head, Post, Options");
            return Ok();
        }

        [HttpOptions("{BookId}")]
        public IActionResult GetBookOptions()
        {
            Response.Headers.Add("Allow", "Get, Head, Put, Patch, Options");
            return Ok();
        }

    }
}
