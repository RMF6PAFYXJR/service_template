using Microsoft.AspNetCore.Mvc;
using service_template.Application.DTOs;
using service_template.Application.UseCases;

namespace service_template.Web.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly CreateUserUseCase _useCase;

    public UserController(CreateUserUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
    {
        await _useCase.ExecuteAsync(request.Username, request.Email);
        return Ok(new { message = "User created successfully" });
    }
}