import { __decorate } from "tslib";
import { Component } from '@angular/core';
let DashboardComponent = class DashboardComponent {
    constructor(router, authService, projectSerivce, supplierService) {
        this.router = router;
        this.authService = authService;
        this.projectService = projectSerivce;
        this.supplierService = supplierService;
    }
    ngOnInit() {
        const token = localStorage.getItem('token');
        this.authService.isAuthenticated(token);
    }
};
DashboardComponent = __decorate([
    Component({
        selector: 'app-dashboard',
        templateUrl: './dashboard.component.html',
        styleUrls: ['./dashboard.component.scss']
    })
], DashboardComponent);
export { DashboardComponent };
//# sourceMappingURL=dashboard.component.js.map