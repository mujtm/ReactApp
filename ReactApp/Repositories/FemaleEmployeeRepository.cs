using System;
using ReactApp.Models;
using System.Data;
using Dapper;

public class FemaleEmployeeRepository
{
    private readonly IDbConnection _dbConnection;

    public FemaleEmployeeRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return _dbConnection.Query<Employee>("SELECT * FROM employees where gender = 'Female'");
    }
}