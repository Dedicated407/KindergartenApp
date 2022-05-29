using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/groups")]
public class GroupController : ControllerBase
{
    private readonly IRepository _repository;

    public GroupController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Group group)
    {
        await _repository.Add(group, "Groups");
        return Ok(group);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<Group>(id, "Groups"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<Group>("Groups"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Group group)
    {
        await _repository.Update(id, group, "Groups");
        return Ok(group);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<Group>(id, "Groups");
        return Ok(id);
    }
}