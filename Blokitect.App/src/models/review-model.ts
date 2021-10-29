﻿
import { SuperViewModel } from './super-model';
export class ReviewViewModel extends SuperViewModel {  
    public subject: string; 
 
    public content: string; 
 
    public reviewerId: number; 
 
    public reviewer: CustomerViewModel; 
 
    public supplier: SupplierViewModel; 
 
    public supplierId: number; 
 
    public rating: number; 
 
    public website: string; 

}

export class ReviewCreateViewModel extends ReviewViewModel { 
}

export class ReviewEditViewModel extends ReviewCreateViewModel { 
}

//end of file