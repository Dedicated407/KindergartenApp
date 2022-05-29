using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiController]
[Route("api/medicalDocuments")]
public class MedicalDocumentsController : ControllerBase
{
    private readonly IRepository _repository;

    public MedicalDocumentsController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] MedicalDocument document)
    {
        await _repository.Add(document, "MedicalDocuments");
        return Ok(document);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _repository.Get<MedicalDocument>(id, "MedicalDocuments"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _repository.GetAll<MedicalDocument>("MedicalDocuments"));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] MedicalDocument document)
    {
        await _repository.Update(id, document, "MedicalDocuments");
        return Ok(document);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(Guid id)
    {
        await _repository.Remove<MedicalDocument>(id, "MedicalDocuments");
        return Ok(id);
    }
}