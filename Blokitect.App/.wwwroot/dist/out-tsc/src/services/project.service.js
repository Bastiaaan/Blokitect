import { __decorate } from "tslib";
import { Service } from './service';
import { Injectable } from '@angular/core';
let ProjectService = class ProjectService extends Service {
    constructor(api) {
        super('project');
        this.api = api;
    }
};
ProjectService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], ProjectService);
export { ProjectService };
//# sourceMappingURL=project.service.js.map