using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/employee")]

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


    [Route("male")]
    [HttpGet]
    public IActionResult GetMaleEmployees()
    {
        var employees = _employeeRepository.GetMaleEmployees();
        return Ok(employees);
    }


    [Route("female")]
    [HttpGet]
    public IActionResult GetFemaleEmployees()
    {
        var employees = _employeeRepository.GetFemaleEmployees();
        return Ok(employees);
    }


}