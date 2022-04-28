using BookLibraryApi.Contexts;
using BookLibraryApi.Entities;
using BookLibraryApi.Models.UserProfileModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly BookContext _context;

        public UserRepository(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            BookContext context)
        {
            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ??
                throw new ArgumentNullException(nameof(roleManager));
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public async Task<List<UserProfileDto>> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            var roles = await _roleManager.Roles.ToListAsync();
            var userRoles = await _context.UserRoles.ToListAsync();

            var usersWithRoles = users.GroupJoin(
                userRoles,
                u => u.Id,
                ur => ur.UserId,
                (u, ur) => new UserProfileDto
                {
                    Id = new Guid(u.Id),
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    UserName = u.UserName,
                    AddedDate = u.AddedDate,
                    Country = u.Country,
                    Address = u.Address,
                    Gender = u.Gender.ToString(),
                    PictureUrl = u.PictureUrl,
                    DateOfBirth = u.DateOfBirth,
                    UpdateDate = u.UpdateDate,

                    Roles = ur.Join(roles, uu => uu.RoleId, ro => ro.Id, (uu, ro) => ro.Name.ToString()).ToList()
                }).ToList();

            return usersWithRoles;
        }
        public async Task<List<string>> GetUserRoles(UserProfileDto user)
        {
            var usersRoles = await _context.UserRoles.Where(ur => ur.UserId == user.Id.ToString()).ToListAsync();

            var roles = usersRoles.Join(_roleManager.Roles.ToList(), ur => ur.RoleId, r => r.Id, (ur, r) =>
            r.Name.ToString()
            ).ToList();

            return roles;
        }
    }
}