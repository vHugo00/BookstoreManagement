using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookstoreController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Hello World! {id}");
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        return Ok($"Hello World! {value}");
    }
    
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        return Ok($"Hello World! {id} {value}");
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return Ok($"Hello World! {id}");
    }
}