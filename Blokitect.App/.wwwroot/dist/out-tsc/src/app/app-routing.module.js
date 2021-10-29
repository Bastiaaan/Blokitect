import { __decorate } from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProjectComponent } from './project/project.component';
import { AuthGuard } from '../services/auth.guard';
import { AboutUsComponent } from './about-us/about-us.component';
import { PrivateRegisterComponent } from './private-register/private-register.component';
const routes = [
    {
        path: '', component: HomeComponent
    },
    {
        path: 'login', component: LoginComponent
    },
    {
        path: 'register', component: RegisterComponent
    },
    {
        path: 'about_us', component: AboutUsComponent
    },
    {
        path: 'dashboard/:userId', component: DashboardComponent, canActivate: [AuthGuard]
    },
    {
        path: 'project/:id/userId', component: ProjectComponent, canActivate: [AuthGuard]
    },
    {
        path: 'register/private', component: PrivateRegisterComponent
    }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = __decorate([
    NgModule({
        imports: [RouterModule.forRoot(routes)],
        exports: [RouterModule]
    })
], AppRoutingModule);
export { AppRoutingModule };
//# sourceMappingURL=app-routing.module.js.map