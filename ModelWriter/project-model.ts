
import { SuperViewModel } from './super-model';import { ComponentViewModel } from './component-model';import { CustomerViewModel } from './customer-model';
export class ProjectViewModel extends SuperViewModel {  
    public progress: number; 
 
    public name: string; 
 
    public description: string; 
 
    public components: ComponentViewModel[]; 
 
    public customer: CustomerViewModel; 
 
    public isActive: boolean; 
 
    public isOnline: boolean; 
 
    public isFinished: boolean; 

}

export class ProjectCreateViewModel extends ProjectViewModel { 
}

export class ProjectEditViewModel extends ProjectCreateViewModel { 
}

//end of file
