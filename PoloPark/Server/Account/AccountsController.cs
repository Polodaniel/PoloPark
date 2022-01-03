﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PoloPark.Server.Model;
using PoloPark.Shared.Model.Account;
using PoloPark.Shared.Model.Account.Result;

namespace PoloPark.Server.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        //private static UserModel LoggedOutUser = new UserModel { IsAuthenticated = false };

        //private readonly UserManager<IdentityUser> _userManager;

        private readonly UserManager<ApplicationUser> _userManager;

        //public AccountsController(UserManager<IdentityUser> userManager) =>
        public AccountsController(UserManager<ApplicationUser> userManager) =>
            _userManager = userManager;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterModel model)
        {
            var newUser = new ApplicationUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return Ok(new RegisterResult { Successful = false, Errors = errors });

            }

            return Ok(new RegisterResult { Successful = true });
        }
    }
}
