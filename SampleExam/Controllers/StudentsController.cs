using Microsoft.AspNetCore.Mvc;
using SampleExam.Services;

namespace SampleExam.Controllers;

[ApiController]
[Route("api/[controller]")] //api/students
public class StudentsController(IDbService db) : ControllerBase
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveStudent(int id)
    {
        var result = await db.RemoveStudent(id);
        if (result is false) return NotFound($"Student with that id is not exists, id: {id}");
        return NoContent();
    }
}