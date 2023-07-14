import { Table } from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.css';

export const NavbarBase = () => {
    
    return (

        <nav class="navbar navbar-expand-lg navbar-dark bg-success">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo03" aria-controls="navbarTogglerDemo03" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <a class="navbar-brand" href="#"><span class="mb-0 h1">HannoVision</span></a>

            <div class="collapse navbar-collapse" id="navbarTogglerDemo03">
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                    <li class="nav-item active">
                        <a class="nav-link" href="#"><span class="mb-0 h3">Home</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><span class="mb-0 h3">Employers</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><span class="mb-0 h3">Services</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><span class="mb-0 h3">Industries</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#"><span class="mb-0 h3">About Us</span></a>
                    </li>
                </ul>
                
  </div>
</nav>

        )

}