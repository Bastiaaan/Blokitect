
import { SuperViewModel } from './super-model';import { ReturnValue,  } from './enums';import { ComponentViewModel } from './component-model';
export class FunctionViewModel extends SuperViewModel {  
    public id: number; 
 
    public returnValue: ReturnValue; 
 
    public component: ComponentViewModel; 
 
    public priority: number; 

}

export class FunctionCreateViewModel extends FunctionViewModel { 
}

export class FunctionEditViewModel extends FunctionCreateViewModel { 
}

//end of file
