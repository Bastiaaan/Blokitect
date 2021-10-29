
import { SuperViewModel } from './super-model';import { CompanyViewModel } from './company-model';
export class ContactPersonViewModel extends SuperViewModel {  
    public firstname: string; 
 
    public lastname: string; 
 
    public email: string; 
 
    public phoneNumber: string; 
 
    public businessFunction: string; 
 
    public supervisor: ContactPersonViewModel; 
 
    public isSupervisor: boolean; 
 
    public isMainContact: boolean; 
 
    public companyId: number; 
 
    public company: CompanyViewModel; 
 
    public position: string; 

}

export class ContactPersonCreateViewModel extends ContactPersonViewModel { 
}

export class ContactPersonEditViewModel extends ContactPersonCreateViewModel { 
}

//end of file
