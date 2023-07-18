using Dapper;
using ReactApp.Models;
using System.Collections.Generic;
using System.Data;

public class EmployeeRepository
{
    private readonly IDbConnection _dbConnection;

    public EmployeeRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return _dbConnection.Query<Employee>("SELECT * FROM employees");
    }


    public IEnumerable<Employee> GetMaleEmployees()
    {
        return _dbConnection.Query<Employee>("SELECT * FROM employees where gender = 'Male'");
    }


    public IEnumerable<Employee> GetFemaleEmployees()
    {
        return _dbConnection.Query<Employee>("SELECT * FROM employees where gender = 'Female'");
    }
}
