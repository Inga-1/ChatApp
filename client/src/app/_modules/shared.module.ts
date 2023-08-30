import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ToastrModule } from 'ngx-toastr';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { TabsModule } from 'ngx-bootstrap/tabs';


@NgModule({
  declarations: [],
  imports: [
    CommonModule, 
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }), 
    
    PaginationModule.forRoot(), 
    TabsModule.forRoot()
  ], 

  exports: [
    ToastrModule,
    PaginationModule,
    TabsModule
  ]
})
export class SharedModule { }
