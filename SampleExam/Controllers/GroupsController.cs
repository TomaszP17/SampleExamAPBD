using Microsoft.AspNetCore.Mvc;
using SampleExam.Services;

namespace SampleExam.Controllers;

[ApiController]
[Route("api/[controller]")] //api/groups
public class GroupsController(IDbService db) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetGroup(int id)
    {
        var result = await db.GetGroupDetailsByIdAsync(id);
        if (result is null) return NotFound($"Group with id: {id} does not exists");
        return Ok(result);
    }
}