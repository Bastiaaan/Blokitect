﻿
import { UserRole,  } from './enums';
export class RegisterViewModel {  
    public companyName: string; 
 
    public chamberOfCommerceNumber: number; 
 
    public vatNumber: string; 
 
    public mailAddress: string; 
 
    public phoneNumber: number; 
 
    public website: string; 
 
    public sectors: string; 
 
    public correspondenceAddress: string; 
 
    public zipCode: string; 
 
    public activities: string; 
 
    public contactPeople: ContactPersonCreateViewModel[]; 
 
    public userRole: UserRole; 

}

//end of file