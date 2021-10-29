import { __decorate } from "tslib";
import * as $ from 'jquery';
import { Injectable } from '@angular/core';
let HelperService = class HelperService {
    constructor(router) {
        this.router = router;
        this.determineActiveNav(this.router.url);
    }
    determineActiveNav(url) {
        $('#nav-menu li a').each(function () {
            let _this = $(this);
            if (url === _this.attr('href')) {
                _this.addClass('active');
            }
        });
    }
};
HelperService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], HelperService);
export { HelperService };
//# sourceMappingURL=helper.service.js.map