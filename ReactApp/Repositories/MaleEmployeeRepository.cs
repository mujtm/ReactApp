using System;
using ReactApp.Models;
using System.Data;
using Dapper;

public class MaleEmployeeRepository
{
    private readonly IDbConnection _dbConnection;

    public MaleEmployeeRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return _dbConnection.Query<Employee>("SELECT * FROM employees where gender = 'Male'");
    }
}
