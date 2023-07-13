import { Table } from 'react-bootstrap'

export const ListEmployees = (props) => {
       const employees = props.data


    return (
        <div>
            <Table striped bordered hover size="sm" >
                <tbody>
                    <tr>
                        <th>Id</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Gender</th>
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
                                    <td>{employee.gender}</td>
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
            </Table>
        </div>
        )

}
