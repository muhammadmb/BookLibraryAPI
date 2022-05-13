using AutoMapper;
using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.UserProfileModels;
using BookLibraryApi.Repositories.UserRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers.AuthenticationControllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [EnableCors("demoPolicy")]
    [Route("api/myProfile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserRepository _userRepository;

        public ProfileController(UserManager<ApplicationUser> userManager, IUserRepository userRepository, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));

            _mapper = mapper ??
                   throw new ArgumentNullException(nameof(mapper));

            _roleManager = roleManager ??
                throw new ArgumentNullException(nameof(roleManager));

            _userRepository = userRepository ??
                throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile()
        {
            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);

            if (loggedInUser == null)
            {
                return NotFound("This user Is not Found");
            }

            var user = _mapper.Map<UserProfileDto>(loggedInUser);
            var roles = await _userRepository.GetUserRoles(user);
            user.Roles = roles;

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> EditProfile([FromBody] UserProfileUpdateDto profileUpdateDto)
        {
            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);

            if (loggedInUser == null)
            {
                return NotFound("This user Is not Found");
            }

            _mapper.Map(profileUpdateDto, loggedInUser);
            await _userManager.UpdateAsync(loggedInUser);

            return NoContent();
        }

        [HttpPatch]
        public async Task<IActionResult> PartialUpdateProfile(
            JsonPatchDocument<UserProfileUpdateDto> patchDocument
            )
        {

            if (patchDocument == null)
            {
                return NotFound();
            }

            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);

            if (loggedInUser == null)
            {
                return NotFound("This user Is not Found");
            }

            var user = _mapper.Map<UserProfileUpdateDto>(loggedInUser);

            patchDocument.ApplyTo(user, ModelState);

            if (!TryValidateModel(user))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(user, loggedInUser);

            await _userManager.UpdateAsync(loggedInUser);

            return NoContent();
        }

    }
}
