using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestAPIMarket.Business.Interfaces;
using TestAPIMarket.Business.Models;
using TestAPIMarket.Controllers.Responses;
using TestAPIMarket.Data.Entities;

namespace TestAPIMarket.Controllers;

[Route("[controller]")]
[ApiController]
[ProducesResponseType(typeof(ApiResponse), 500)]

public class UserControllers : ControllerBase
{
    private readonly IUsersServices _usersServices;

    public UserControllers(IUsersServices usersServices)
    {
        _usersServices = usersServices;
    }
    
    // Post api/users/
    [HttpPost("addUser")]
    [Route("AddUsers")]
    [Authorize(Roles = $"{Role.Administrator}")]
    [ProducesResponseType(typeof(ApiValueResponse<int>), 200)]
    public async Task<IActionResult> CreateAsync(UserDto user) {
    
        await _usersServices.AddUsersAsync(user);
        return Ok(ApiValueResponse<int>.Success("Пользователь успешно создан", user.Id));
    }    
}