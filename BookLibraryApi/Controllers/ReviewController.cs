using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.ReviewModels;
using BookLibraryApi.Repositories.ReviewsRepository;
using BookLibraryApi.ResourceParameters;
using BookLibraryApi.Services;
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
    [Route("api/genres/{genreId}/Books/{bookId}/reviews")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewsRepository _reviewsRepository;
        private readonly IPropertyCheckerService _propertyCheckerService;
        private readonly IMapper _mapper;

        public ReviewController(
            IReviewsRepository reviewsRepository,
            IPropertyCheckerService propertyCheckerService,
            IMapper mapper)
        {
            _reviewsRepository = reviewsRepository ??
                throw new ArgumentNullException(nameof(reviewsRepository));
            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(Name = "GetReviews")]
        [HttpHead]
        public async Task<IActionResult> GetReviewsForBook(
            Guid genreId,
            Guid bookId,
            [FromQuery] ReviewResourcesParameters parameters)
        {

            if (!_propertyCheckerService.TypeHasProperties<ReviewDto>(parameters.Fields))
            {
                return NotFound();
            }

            var reviewsFromRepo = await _reviewsRepository.GetReviews(genreId, bookId, parameters);

            if (reviewsFromRepo == null)
            {
                return NotFound();
            }

            var reviewsToReturn = _mapper.Map<IEnumerable<ReviewDto>>(reviewsFromRepo).ShapeData(parameters.Fields);

            return Ok(reviewsToReturn);
        }

        [HttpGet("{reviewId}", Name = "GetReview")]
        [HttpHead("{reviewId}")]
        public async Task<IActionResult> GetReviewForBook(
            Guid genreId,
            Guid bookId,
            Guid reviewId,
            [FromQuery] string fields)
        {

            if (!_propertyCheckerService.TypeHasProperties<ReviewDto>(fields))
            {
                return NotFound();
            }

            var reviewFromRepo = await _reviewsRepository.GetReview(genreId, bookId, reviewId);

            if (reviewFromRepo == null)
            {
                return NotFound();
            }

            var reviewsToReturn = _mapper.Map<ReviewDto>(reviewFromRepo).ShapeData(fields);

            return Ok(reviewsToReturn);
        }
        [HttpPost()]
        public async Task<IActionResult> AddReview(
            Guid genreId,
            Guid bookId,
            ReviewCreation reviewCreation)
        {
            if (reviewCreation == null)
            {
                return NotFound();
            }

            var review = _mapper.Map<Review>(reviewCreation);
            review.BookId = reviewCreation.BookId != null ? reviewCreation.BookId : bookId;

            _reviewsRepository.CreateReview(review);
            await _reviewsRepository.saveChangesAsync();

            return CreatedAtRoute("GetReview",
                new { genreId, bookId = review.BookId, reviewId = review.Id },
                "the review added successfuly");
        }

        [HttpPut("{reviewId}")]
        public async Task<IActionResult> UpdateReview(
            Guid genreId,
            Guid bookId,
            Guid ReviewId,
            ReviewUpdate reviewUpdate)
        {
            if (reviewUpdate == null)
            {
                return NotFound();
            }

            var reviewFromRepo = await _reviewsRepository.GetReview(genreId, bookId, ReviewId);

            if (reviewFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(reviewUpdate, reviewFromRepo);

            _reviewsRepository.UpdateReview(reviewFromRepo);
            await _reviewsRepository.saveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{reviewId}")]
        public async Task<IActionResult> PartialUpdateReview(
            Guid genreId,
            Guid bookId,
            Guid ReviewId,
            JsonPatchDocument<ReviewUpdate> document
            )
        {
            if (document == null)
            {
                return NotFound();
            }

            var reviewFromRepo = await _reviewsRepository.GetReview(genreId, bookId, ReviewId);

            if (reviewFromRepo == null)
            {
                return NotFound();
            }

            var review = _mapper.Map<ReviewUpdate>(reviewFromRepo);

            document.ApplyTo(review, ModelState);

            if (!TryValidateModel(review))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(review, reviewFromRepo);
            _reviewsRepository.UpdateReview(reviewFromRepo);
            await _reviewsRepository.saveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{reviewId}")]
        public async Task<IActionResult> DeleteReview(
            Guid genreId,
            Guid bookId,
            Guid reviewId)
        {
            _reviewsRepository.Delete(bookId ,reviewId);
            await _reviewsRepository.saveChangesAsync();
            return NoContent();
        }

        [HttpOptions()]
        public IActionResult GetReviewsOptions()
        {
            Response.Headers.Add("Allow", "Get, Post, Head, Options");
            return Ok();
        }

        [HttpOptions("{reviewId}")]
        public IActionResult GetReviewOptions()
        {
            Response.Headers.Add("Allow", "Get, Post, Put, Patch, Head, Options");
            return Ok();
        }
    }
}
