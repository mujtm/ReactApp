import React from 'react';
import Paper from '@mui/material/Paper';
import { ListEmployees } from './components/ListEmployees';
import { EmployeeTabs } from './components/EmployeeTabs';
import { NavbarBase } from './components/NavbarBase';

function App() {
  
    return (
        <div className="App" >
            
            <NavbarBase/>
            <EmployeeTabs/>
            
        </div>
        
    );
}

export default App;
