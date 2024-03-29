﻿using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.BookModels;
using BookLibraryApi.Repositories.BookReposittory;
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
    [ApiController]
    [EnableCors("demoPolicy")]
    [Route("api/Genres/{GenreId}/Books")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master, Editor")]
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
        [AllowAnonymous]
        public async Task<IActionResult> GetBooks(Guid GenreId,
            [FromQuery] BookResourceParameters parameters)
        {

            if (!_propertyCheckerService.TypeHasProperties<BookDto>(parameters.Fields))
            {
                return NotFound();
            }

            var Books = await _bookRepository.GetBooks(GenreId, parameters);

            if (Books == null)
            {
                return NotFound();
            }

            var paginationMetadata = new
            {
                pageSize = Books.PageSize,
                currentPage = Books.CurrentPage,
                hasNext = Books.HasNext,
                hasPrevious = Books.HasPrevious,
                totalPages = Books.TotalPages,
                totalCount = Books.TotalCount
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetadata));

            var BooksToReturn = _mapper.Map<IEnumerable<BookDto>>(Books).ShapeData(parameters.Fields);
            return Ok(BooksToReturn);
        }

        [HttpGet("{BookId}", Name = "GetBook")]
        [HttpHead("{BookId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBook(
            Guid GenreId,
            Guid BookId,
            [FromQuery] string fields)
        {
            if (!_propertyCheckerService.TypeHasProperties<BookDto>(fields))
            {
                return NotFound();
            }

            var BookFromRepo = await _bookRepository.GetBook(GenreId, BookId);

            if (BookFromRepo == null)
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
            if (bookCreation == null)
            {
                throw new ArgumentNullException(nameof(bookCreation));
            }

            var book = _mapper.Map<Book>(bookCreation);
            _bookRepository.Create(GenreId, book);
            await _bookRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetBook",
                new { book.GenreId, BookId = book.Id },
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

            if (bookFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(bookUpdate, bookFromRepo);
            _bookRepository.Update(bookFromRepo);
            await _bookRepository.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{BookId}")]
        public async Task<IActionResult> PartialUpdate(Guid GenreId, Guid BookId, JsonPatchDocument<BookUpdate> patchDocument)
        {
            var bookFromRepo = await _bookRepository.GetBook(GenreId, BookId);

            if (bookFromRepo == null)
            {
                return NotFound();
            }

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

        [HttpDelete("{bookId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master")]
        public async Task<IActionResult> DelteBook(Guid GenreId, Guid BookId)
        {
            _bookRepository.Delete(GenreId, BookId);
            await _bookRepository.SaveChangesAsync();
            return (NoContent());
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
