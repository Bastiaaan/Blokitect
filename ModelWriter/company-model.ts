
import { SuperViewModel } from './super-model';import { ContactPersonViewModel } from './contactPerson-model';
export class CompanyViewModel extends SuperViewModel {  
    public companyName: string; 
 
    public chamberOfCommerceNumber: number; 
 
    public vatNumber: string; 
 
    public mailAddress: string; 
 
    public correspondenceAddress: string; 
 
    public phoneNumber: number; 
 
    public logo: number[]; 
 
    public contactPeople: ContactPersonViewModel[]; 

}

//end of file
