using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/parents")]
public class ParentController : ControllerBase
{
    private readonly IRepository _repository;

    public ParentController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Parent parent)
    {
        await _repository.Add(parent, "Parents");
        return Ok(parent);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<Parent>(id, "Parents"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<Parent>("Parents"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Parent parent)
    {
        await _repository.Update(id, parent, "Parents");
        return Ok(parent);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<Parent>(id, "Parents");
        return Ok(id);
    }
}