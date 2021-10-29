import { Component, OnInit } from '@angular/core';
import { HelperService } from '../../services/helper.service';
import { ComponentViewModel } from './../../models/component-model';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private helperService: HelperService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    console.log(this.activatedRoute);
  }

}
