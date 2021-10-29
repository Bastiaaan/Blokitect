import { __decorate } from "tslib";
import { Service } from './service';
import { Injectable } from '@angular/core';
let ComponentService = class ComponentService extends Service {
    constructor(api) {
        super('component');
        this.api = api;
    }
};
ComponentService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], ComponentService);
export { ComponentService };
//# sourceMappingURL=component.service.js.map