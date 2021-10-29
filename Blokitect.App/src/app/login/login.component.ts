import { Component, Input, OnInit, Inject } from '@angular/core';
import { LoginViewModel } from './../../models/login-model';
import { HelperService } from '../../services/helper.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  @Input() model: LoginViewModel;

  constructor(private helperService: HelperService) {
  }

  ngOnInit(): void {
    // TODO: Determine on URL basis if a producer or customer is signing in
    this.model = new LoginViewModel();
  }

  submitLogin() {
    console.log('submit works');
  }

}
