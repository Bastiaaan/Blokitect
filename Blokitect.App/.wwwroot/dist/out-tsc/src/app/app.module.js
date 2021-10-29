import { __decorate } from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProjectComponent } from './project/project.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { OpenProjectsComponent } from './open-projects/open-projects.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTabsModule } from '@angular/material/tabs';
import { MatExpansionModule } from '@angular/material/expansion';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AboutUsComponent } from './about-us/about-us.component';
import { PrivateRegisterComponent } from './private-register/private-register.component';
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
        declarations: [
            AppComponent,
            HomeComponent,
            DashboardComponent,
            ProjectComponent,
            LoginComponent,
            RegisterComponent,
            OpenProjectsComponent,
            AboutUsComponent,
            PrivateRegisterComponent
        ],
        imports: [
            BrowserModule,
            FormsModule,
            AppRoutingModule,
            BrowserAnimationsModule,
            MatTabsModule,
            MatExpansionModule,
            FontAwesomeModule,
        ],
        providers: [],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map