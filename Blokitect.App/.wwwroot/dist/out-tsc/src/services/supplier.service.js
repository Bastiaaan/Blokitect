import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
import { Service } from './service';
let SupplierService = class SupplierService extends Service {
    constructor() {
        super('supplier');
    }
};
SupplierService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], SupplierService);
export { SupplierService };
//# sourceMappingURL=supplier.service.js.map