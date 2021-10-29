import { Service } from './service';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProjectService extends Service {

  constructor(private api: HttpClient) {
    super('project');
  }



}
