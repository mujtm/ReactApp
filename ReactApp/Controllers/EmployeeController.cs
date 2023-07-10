using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeRepository _employeeRepository;

    public EmployeeController(EmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = _employeeRepository.GetEmployees();
        return Ok(employees);
    }
}


