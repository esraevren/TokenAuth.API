﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TokenAuth.API.DTOs;
using TokenAuth.API.Services;

namespace TokenAuth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentitiesController(IdentityService _identityService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateRequestDto request)
        {
            var response = await _identityService.CreateUser(request);

            if (response.AnyError)
            {
                return BadRequest(response);
            }

            return Created();
        }
    }
}
