using CommentManagementService.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CommentManagementService.Controllers;

[Route("api/comments")]
[ApiController]
public sealed class CommentController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateComment([FromBody] CommentCreateInfo postCreateInfo)
    {
        return Ok();
    }

    [HttpPut("{id::guid}")]
    public IActionResult UpdateComment([FromRoute] Guid id, [FromBody] CommentUpdateInfo postUpdateInfo)
    {
        return Ok();
    }

    [HttpGet("{id::guid}")]
    [ProducesResponseType(typeof(CommentReadInfo), StatusCodes.Status200OK)]
    public IActionResult GetComment([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CommentReadInfo>), StatusCodes.Status200OK)]
    public IActionResult GetComments()
    {
        return Ok();
    }

    [HttpDelete("{id::guid}")]
    public IActionResult DeleteComment([FromRoute] Guid id)
    {
        return Ok();
    }
}