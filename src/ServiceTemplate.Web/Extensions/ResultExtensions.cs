using Microsoft.AspNetCore.Mvc;
using ServiceTemplate.Application.Common.Results;

namespace ServiceTemplate.Web.Extensions;

public static class ResultExtensions
{
    public static ActionResult ToActionResult(this Result result)
    {
        if (result.IsSuccess)
            return new OkResult();

        return result.Error switch
        {
            { Code: var code } when code.Contains("NotFound") => new NotFoundObjectResult(result.Error),
            { Code: var code } when code.Contains("Invalid") => new BadRequestObjectResult(result.Error),
            _ => new ObjectResult(result.Error) { StatusCode = 500 }
        };
    }

    public static ActionResult ToActionResult<T>(this Result<T> result)
    {
        if (result.IsSuccess)
            return new OkObjectResult(result.Value);

        return result.Error switch
        {
            { Code: var code } when code.Contains("NotFound") => new NotFoundObjectResult(result.Error),
            { Code: var code } when code.Contains("Invalid") => new BadRequestObjectResult(result.Error),
            _ => new ObjectResult(result.Error) { StatusCode = 500 }
        };
    }
}