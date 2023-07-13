import React, { useState, useEffect } from 'react';
import Paper from "@mui/material/Paper";
import Tab from "@mui/material/Tab";
import Tabs from "@mui/material/Tabs";
import { ListEmployees } from './ListEmployees';

export const EmployeeTabs = () => {
    const [value, setValue] = React.useState(0);
    const [employees, setEmployees] = useState([]);
    
    var url = ''

    if (value == 0) {
        url = 'https://localhost:7186/api/employee'
    }
    else if (value == 1) {
        url = 'https://localhost:7186/api/employee/male'
    }
    else {
        url = 'https://localhost:7186/api/employee/female'
    }

    useEffect(() => {
        async function getData() {
            const response = await fetch(url)
            const data = await response.json()
            setEmployees(data)
        }
        getData();
    }, [value]);

    return (
        <div>
            <h1 className="text-success">List of Employees</h1>

            <Paper square>
                <Tabs
                    value={value}
                    textColor="primary"
                    indicatorColor="primary"
                    onChange={(event, newValue) => {
                        setValue(newValue);
                    }}
                >
                    <Tab label="All Employees" />
                    <Tab label="Male" />
                    <Tab label="Female" />
                </Tabs>
            </Paper>
            <ListEmployees data={employees} />
        </div>
    );
};

