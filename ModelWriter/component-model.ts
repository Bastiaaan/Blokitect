﻿
import { SuperViewModel } from './super-model';
export class ComponentViewModel extends SuperViewModel {  
    public type: number; 
 
    public functions: FunctionViewModel[]; 
 
    public projectId: number; 
 
    public project: ProjectViewModel; 

}

export class ComponentCreateViewModel extends ComponentViewModel { 
}

export class ComponentEditViewModel extends ComponentCreateViewModel { 
}

//end of file