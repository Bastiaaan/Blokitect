
import { CompanyViewModel } from './company-model';import { SupplierType,  } from './enums';
export class SupplierViewModel extends CompanyViewModel {  
    public type: SupplierType; 
 
    public penaultyPoints: number; 

}

export class SupplierCreateViewModel extends SupplierViewModel { 
}

export class SupplierEditViewModel extends SupplierCreateViewModel { 
}

//end of file
