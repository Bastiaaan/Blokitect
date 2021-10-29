import * as $ from 'jquery';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class HelperService {

  constructor(private router: Router) {
    this.determineActiveNav(this.router.url);
  }

  determineActiveNav(url: string) {

    $('#nav-menu li a').each(function () {
      let _this = $(this);
      if (url === _this.attr('href')) {
        _this.addClass('active');
      }
    });
  }
}

