using Microsoft.AspNetCore.Mvc;
using ServiceTemplate.Application.DTOs;
using ServiceTemplate.Application.UseCases;

namespace ServiceTemplate.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(CreateUserUseCase useCase) : ControllerBase
{
    [HttpPost("create")]
    [ProducesResponseType(typeof(CreateUserRequest), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
    {
        await useCase.ExecuteAsync(request.Username, request.Email);
        return Ok(new { message = "User created successfully" });
    }
}