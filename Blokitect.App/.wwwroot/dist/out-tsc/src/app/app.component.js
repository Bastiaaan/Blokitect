import { __decorate } from "tslib";
import * as $ from 'jquery';
import { Component, ViewEncapsulation } from '@angular/core';
import { faUser, faAngleDown } from '@fortawesome/free-solid-svg-icons';
let AppComponent = class AppComponent {
    constructor(router, activatedRoute) {
        this.router = router;
        this.activatedRoute = activatedRoute;
        this.title = 'Idea > software plan';
        this.faUser = faUser;
        this.faAngleDown = faAngleDown;
        console.log(this.activatedRoute);
    }
    ngOnInit() {
        $('#nav-menu li a:not(.active)').click(function (e) {
            e.preventDefault();
            const _this = $(this);
            $('#nav-menu li a.active').each(function () {
                $(this).removeClass('active');
            });
            _this.addClass('active');
        });
    }
    navigate() {
    }
};
AppComponent = __decorate([
    Component({
        selector: 'app-root',
        encapsulation: ViewEncapsulation.None,
        templateUrl: './app.component.html',
        styleUrls: ['./app.component.scss']
    })
], AppComponent);
export { AppComponent };
//# sourceMappingURL=app.component.js.map