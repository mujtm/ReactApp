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

[Route("api/employee/[controller]")]
public class MaleController : ControllerBase
{
    private readonly MaleEmployeeRepository _maleEmployeeRepository;

    public MaleController(MaleEmployeeRepository maleEmployeeRepository)
    {
        _maleEmployeeRepository = maleEmployeeRepository;
    }

    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = _maleEmployeeRepository.GetEmployees();
        return Ok(employees);
    }
}

[Route("api/employee/[controller]")]
public class FemaleController : ControllerBase
{
    private readonly FemaleEmployeeRepository _femaleEmployeeRepository;

    public FemaleController(FemaleEmployeeRepository femaleEmployeeRepository)
    {
        _femaleEmployeeRepository = femaleEmployeeRepository;
    }

    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = _femaleEmployeeRepository.GetEmployees();
        return Ok(employees);
    }
}

