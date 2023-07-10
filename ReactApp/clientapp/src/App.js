import React, { useState, useEffect } from 'react';

function App() {
    const [employees, setEmployees] = useState([]);

    const url = 'https://localhost:7186/api/employee'


    useEffect(() => {
        async function getData() {

            const response = await fetch(url)
            const data = await response.json()
            setEmployees(data)
        }
        getData();


    }, []);


    return (
        <div className="App">
            <h1>List of Employees</h1>
            <table>
                <tbody>
                    <tr>
                        <th>Id</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Age</th>
                        <th>Department</th>
                        <th>Email</th>
                        <th>Phone Number</th>
                        <th>Address Line</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                    </tr>

                    {

                        employees.map((employee, key) => {
                            return (
                                <tr key={employee.id}>
                                    <td>{employee.id}</td>
                                    <td>{employee.first_name}</td>
                                    <td>{employee.last_name}</td>
                                    <td>{employee.age}</td>
                                    <td>{employee.department}</td>
                                    <td>{employee.email}</td>
                                    <td>{employee.phone_number}</td>
                                    <td>{employee.address_line_1}</td>
                                    <td>{employee.city}</td>
                                    <td>{employee.state}</td>
                                    <td>{employee.zip}</td>
                                </tr>
                            )
                        })
                    }

                </tbody>
            </table>


        </div>
    );
}

export default App;
