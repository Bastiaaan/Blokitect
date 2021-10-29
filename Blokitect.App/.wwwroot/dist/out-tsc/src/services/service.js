import { __decorate, __param } from "tslib";
import { environment } from '../environments/environment';
import { Inject, Injectable } from '@angular/core';
//import { of } from 'rxjs/operator';
let Service = class Service {
    constructor(serviceName) {
        serviceName === null ? this.apiUrl : this.apiUrl += `${environment.endPoints.api}/${serviceName}/`;
    }
    addHeader(key, value) {
        if (!this.headerExists(key)) {
            this.headers[key] = value;
        }
        throw new Error(`the key ${key} already exists`);
    }
    removeHeader(key) {
        if (this.headerExists(key)) {
            this.headers[key] = null;
        }
        throw new Error(`the key ${key} is not found`);
    }
    headerExists(key) {
        return this.headers[key] !== null;
    }
};
Service = __decorate([
    Injectable({
        providedIn: 'root'
    }),
    __param(0, Inject(String))
], Service);
export { Service };
//# sourceMappingURL=service.js.map