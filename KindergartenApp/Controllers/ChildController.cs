using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/children")]
public class ChildController : ControllerBase
{
    private readonly IRepository _repository;

    public ChildController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Child child)
    {
        await _repository.Add(child, "Children");
        return Ok(child);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<Child>(id, "Children"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<Child>("Children"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Child child)
    {
        await _repository.Update(id, child, "Children");
        return Ok(child);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<Child>(id, "Children");
        return Ok(id);
    }
}