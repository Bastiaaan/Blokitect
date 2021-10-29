
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProjectService } from './project.service';
import { Service } from './service';

@Injectable({
  providedIn: 'root'
})
export class SupplierService extends Service {
  constructor() {
    super('supplier');
  }
}
