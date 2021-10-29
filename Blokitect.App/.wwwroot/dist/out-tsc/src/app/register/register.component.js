import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { RegisterViewModel } from './../../models/register-model';
import { ContactPersonCreateViewModel } from './../../models/contactPerson-model';
import { faPlusCircle } from '@fortawesome/free-solid-svg-icons';
let RegisterComponent = class RegisterComponent {
    constructor(helperService, route, router) {
        this.helperService = helperService;
        this.route = route;
        this.router = router;
        this.faPlusCircle = faPlusCircle;
    }
    ngOnInit() {
        this.model = new RegisterViewModel();
        this.model.contactPeople = [];
        this.model.contactPeople[0] = new ContactPersonCreateViewModel();
    }
    addNewContactPerson() {
        const newIndex = this.model.contactPeople.length;
        this.model.contactPeople[newIndex] = new ContactPersonCreateViewModel();
    }
    register() {
    }
};
RegisterComponent = __decorate([
    Component({
        selector: 'app-register',
        templateUrl: './register.component.html',
        styleUrls: ['./register.component.scss']
    })
], RegisterComponent);
export { RegisterComponent };
//# sourceMappingURL=register.component.js.map