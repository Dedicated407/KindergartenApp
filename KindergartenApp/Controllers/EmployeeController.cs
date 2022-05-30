using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeeController : ControllerBase
{
    private readonly IRepository _repository;

    public EmployeeController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Employee employee)
    {
        await _repository.Add(employee, "Employees");
        return Ok(employee);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<Employee>(id, "Employees"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<Employee>("Employees"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Employee employee)
    {
        await _repository.Update(id, employee, "Employees");
        return Ok(employee);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<Employee>(id, "Employees");
        return Ok(id);
    }
}