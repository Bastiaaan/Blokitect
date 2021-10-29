import { Component, OnInit, Inject } from '@angular/core';
import { RegisterViewModel } from './../../models/register-model';
import { ContactPersonCreateViewModel } from './../../models/contactPerson-model';
import { ActivatedRoute, Router } from '@angular/router';
//import { faPlusCircle } from 'font-awesome/fonts';
import { HelperService } from '../../services/helper.service';
import { AuthService } from '../../services/auth.service';
import { UserRole } from '../../models/enums';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
@Inject(AuthService)
export class RegisterComponent implements OnInit {

  //faPlusCircle = faPlusCircle;
  model: RegisterViewModel;
  authService: AuthService;
  agreed: boolean;

  constructor(private helperService: HelperService, private route: ActivatedRoute, private router: Router, authService: AuthService) {
    this.authService = authService;
  }

  ngOnInit(): void {
    this.model = new RegisterViewModel();

    this.model.userRole = UserRole.Customer;
    this.model.contactPeople = [];
    this.model.contactPeople[0] = new ContactPersonCreateViewModel();
    this.model.contactPeople[0].position = "eigenaar";
  }

  addNewContactPerson() {
    const newIndex = this.model.contactPeople.length;
    this.model.contactPeople[newIndex] = new ContactPersonCreateViewModel();
  }

  register() {
    this.authService.register(this.model);
  }

}
