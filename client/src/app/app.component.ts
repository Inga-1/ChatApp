import { Component, OnInit } from '@angular/core';
import { AccountService } from './_services/account.service';
import { User } from './_models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  //properties initialized first, then constr, then functions (c# i nman)
  title = 'Chatting app';


  //dependency injection
  constructor (private accountService: AccountService) {}


  ngOnInit(): void {
    this.setCurrentuser();
  }


  setCurrentuser (){
    const userString = localStorage.getItem('user');
    if(!userString) return;
    const user: User = JSON.parse(userString);
    this.accountService.setCurrentUser(user);
  }
}
