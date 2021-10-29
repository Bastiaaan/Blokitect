import { __decorate } from "tslib";
import { Component, Input } from '@angular/core';
import { LoginViewModel } from './../../models/login-model';
let LoginComponent = class LoginComponent {
    constructor(helperService) {
        this.helperService = helperService;
    }
    ngOnInit() {
        // TODO: Determine on URL basis if a producer or customer is signing in
        this.model = new LoginViewModel();
    }
    submitLogin() {
        console.log('submit works');
    }
};
__decorate([
    Input()
], LoginComponent.prototype, "model", void 0);
LoginComponent = __decorate([
    Component({
        selector: 'app-login',
        templateUrl: './login.component.html',
        styleUrls: ['./login.component.scss']
    })
], LoginComponent);
export { LoginComponent };
//# sourceMappingURL=login.component.js.map