using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/vaccinations")]
public class VaccinationController : ControllerBase
{
    private readonly IRepository _repository;

    public VaccinationController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Vaccination vaccination)
    {
        await _repository.Add(vaccination, "Vaccinations");
        return Ok(vaccination);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<Vaccination>(id, "Vaccinations"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<Vaccination>("Vaccinations"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Vaccination vaccination)
    {
        await _repository.Update(id, vaccination, "Vaccinations");
        return Ok(vaccination);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<Vaccination>(id, "Vaccinations");
        return Ok(id);
    }
}