import { Component, OnInit } from '@angular/core';
import { AuthService } from './../../services/auth.service';
import { ProjectViewModel } from '../../models/project-model';
import { CustomerViewModel } from '../../models/customer-model';
import { SupplierViewModel } from '../../models/supplier-model';
import { Router } from '@angular/router';
import { ProjectService } from '../../services/project.service';
import { SupplierService } from '../../services/supplier.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  authService: AuthService;

  projectService: ProjectService;

  supplierService: SupplierService;

  model: {
    project: ProjectViewModel;
    customer: CustomerViewModel;
    supplier: SupplierViewModel;
  };

  constructor(private router: Router, authService: AuthService, projectSerivce: ProjectService, supplierService: SupplierService) {
    this.authService = authService;
    this.projectService = projectSerivce;
    this.supplierService = supplierService;
  }

  ngOnInit(): void {
    const token = localStorage.getItem('token');
    this.authService.isAuthenticated(token);
  }

}
