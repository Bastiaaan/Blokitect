
import { SuperViewModel } from './super-model';import { CustomerViewModel } from './customer-model';import { SupplierViewModel } from './supplier-model';
export class CustomerSupplierViewModel extends SuperViewModel {  
    public customer: CustomerViewModel; 
 
    public customerId: number; 
 
    public supplier: SupplierViewModel; 
 
    public supplierId: number; 

}

//end of file
