import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  //properties initialized first, then constr, then functions (c# i nman)
  title = 'Dating app';
  users: any;

  //dependency injection
  constructor (private http: HttpClient) {}


  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: response => this.users = response, //assigning the response we get from the http request to the users 
      error: error => console.log(error), 
      complete: () => console.log('Request has completed') 
    })
  }
}
