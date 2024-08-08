using Microsoft.AspNetCore.Mvc;
using PostManagementService.DTOs;

namespace PostManagementService.Controllers;

[Route("api/posts")]
[ApiController]
public sealed class PostController : ControllerBase
{
    [HttpPost]
    public IActionResult CreatePost([FromBody] PostCreateInfo postCreateInfo)
    {
        return Ok();
    }

    [HttpPut("{id::guid}")]
    public IActionResult UpdatePost([FromRoute] Guid id, [FromBody] PostUpdateInfo postUpdateInfo)
    {
        return Ok();
    }

    [HttpGet("{id::guid}")]
    [ProducesResponseType(typeof(PostReadInfo), StatusCodes.Status200OK)]
    public IActionResult GetPost([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<PostReadInfo>), StatusCodes.Status200OK)]
    public IActionResult GetPosts()
    {
        return Ok();
    }

    [HttpDelete("{id::guid}")]
    public IActionResult DeletePost([FromRoute] Guid id)
    {
        return Ok();
    }
}