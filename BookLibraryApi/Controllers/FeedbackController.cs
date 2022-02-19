using AutoMapper;
using BookLibraryApi.Entities;
using BookLibraryApi.Helper;
using BookLibraryApi.Models.FeedbackModels;
using BookLibraryApi.Repositories.FeedbackRepository;
using BookLibraryApi.ResourceParameters;
using BookLibraryApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [Route("api/Feedback")]
    [ApiController]
    [EnableCors("demoPolicy")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Master, Editor")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackRepository _feedbackRepository;
        private readonly IPropertyCheckerService _propertyCheckerService;
        private readonly IMapper _mapper;

        public FeedbackController(
            IFeedbackRepository feedbackRepository,
            IPropertyCheckerService propertyCheckerService,
            IMapper mapper)
        {
            _feedbackRepository = feedbackRepository ??
                throw new ArgumentNullException(nameof(feedbackRepository));
            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetFeedbacks(
            [FromQuery] ResourcesParameters parameters
            )
        {

            if (!_propertyCheckerService.TypeHasProperties<Feedback>(parameters.Fields))
            {
                return NotFound();
            }

            var feedbacks = await _feedbackRepository.GetFeedbacks(parameters);

            if (feedbacks == null)
            {
                return NotFound();
            }

            return Ok(feedbacks.ShapeData(parameters.Fields));
        }

        [HttpGet("{Id}", Name = "GetFeedback")]
        public async Task<IActionResult> GetFeedback(Guid Id, string fields)
        {

            if (!_propertyCheckerService.TypeHasProperties<Feedback>(fields))
            {
                return NotFound();
            }

            var feedback = await _feedbackRepository.GetFeedback(Id);

            if (feedback == null)
            {
                return NotFound();
            }

            return Ok(feedback.ShapeData(fields));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackCreationDto creationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (creationDto == null)
            {
                throw new ArgumentNullException(nameof(creationDto));
            }

            var feedback = _mapper.Map<Feedback>(creationDto);

            _feedbackRepository.Create(feedback);
            await _feedbackRepository.SaveChangesAsync();

            return CreatedAtRoute(
                "GetFeedback",
                new { feedback.Id },
                "The feedback Added Succesfully"
                );
        }

        [HttpPatch("{Id}")]
        public async Task<IActionResult> PartialUpdate(Guid Id, JsonPatchDocument<FeedbackUpdateDto> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }

            var feedbackFromRepo = await _feedbackRepository.GetFeedback(Id);

            if (feedbackFromRepo == null)
            {
                return NotFound();
            }

            var feedback = _mapper.Map<FeedbackUpdateDto>(feedbackFromRepo);

            patchDocument.ApplyTo(feedback, ModelState);

            if (!TryValidateModel(feedback))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(feedback, feedbackFromRepo);
            _feedbackRepository.Update(feedbackFromRepo);
            await _feedbackRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
