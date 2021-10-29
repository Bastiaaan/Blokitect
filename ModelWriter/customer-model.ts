
import { CompanyViewModel } from './company-model';import { ProjectViewModel } from './project-model';
export class CustomerViewModel extends CompanyViewModel {  
    public customerId: number; 
 
    public customer: CustomerViewModel; 
 
    public projectId: number; 
 
    public project: ProjectViewModel; 

}

export class CustomerCreateViewModel extends CustomerViewModel { 
}

export class CustomerEditViewModel extends CustomerCreateViewModel { 
}

//end of file
