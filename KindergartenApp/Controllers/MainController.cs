using KindergartenApp.Entities;
using KindergartenApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KindergartenApp.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[Route("home")]
public class MainController : Controller
{
    private readonly IRepository _repository;

    public MainController(IRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public ViewResult MainPage() => View(_repository);
    
    [HttpGet("allChildren")]
    public async Task<ViewResult> ChildPage() => View(await _repository.GetAll<Child>("Children"));
    
    [HttpGet("allParents")]
    public async Task<ViewResult> ParentPage() => View(await _repository.GetAll<Parent>("Parents"));
    
    [HttpGet("allEmployees")]
    public async Task<ViewResult> EmployeePage() => View(await _repository.GetAll<Employee>("Employees"));
    
    [HttpGet("allGroups")]
    public async Task<ViewResult> GroupPage() => View(await _repository.GetAll<Group>("Groups"));
    
    [HttpGet("allVaccinations")]
    public async Task<ViewResult> VaccinationPage() => View(await _repository.GetAll<Vaccination>("Vaccinations"));
}