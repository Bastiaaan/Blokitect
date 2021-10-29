
import { SuperViewModel } from './super-model';import { ProjectViewModel } from './project-model';
export class PrivateViewModel extends SuperViewModel {  
    public firstName: string; 
 
    public lastName: string; 
 
    public email: string; 
 
    public phoneNumber: string; 
 
    public projects: ProjectViewModel[]; 

}

export class PrivateCreateViewModel extends PrivateViewModel { 
}

export class PrivateEditViewModel extends PrivateCreateViewModel { 
}

//end of file
