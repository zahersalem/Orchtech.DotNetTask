import { Component } from '@angular/core';
import EnrolmentService from '../services/Enrolment.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent extends OnInit{
  constructor(
    private enrolmentService:EnrolmentService
  ){
    super();
  }
  classes=[]
  selectedClass=null;
  enrolments:any
  columns=[]

  ngOnInt(){
      this.getData();
      this.setColumns()
      this.setOptions()
  }
  setColumns(){
    this.columns=[
      {header:'StudentName',label:'studentName'},
      {header:'Gender',label:'gender'},
      {header:'Mobile',label:'mobile'},
    ]
  }

  setOptions(){
      this.classes=[{lavel:'Male',value:1},
                    {lavel:'Female',value:2},
                    {lavel:'all',value:3}]
  }

  onChange(){
    this.getData();
  }
  getData(){
    this.enrolmentService.get(this.selectedClass).subscribe(res=> {
      this.enrolments=res
    });

  }
}
