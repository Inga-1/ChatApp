import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Member } from '../_models/member';
import { PaginatedResult } from '../_models/pagination';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class MembersService {
  baseUrl = environment.apiUrl;
  members: Member[] = [];
  paginatedResult: PaginatedResult<Member[]> = new PaginatedResult<Member[]>;

  constructor(private http: HttpClient) { }

  getMembers(page?:number, itemsPerPage?: number)
  {
    let params = new HttpParams();

    if(page && itemsPerPage){
      params = params.append('pageNumber', page); 
      params = params.append('pageSize', itemsPerPage)
    }

    return this.http.get<Member[]>(this.baseUrl + 'users', {observe: 'response', params}).pipe(
      map(response => {
        if(response.body){
          this.paginatedResult.result= response.body;
        }

        const pagination = response.headers.get('Pagination');
        if (pagination){
          this.paginatedResult.pagination = JSON.parse(pagination);
        }
        return this.paginatedResult;
      })
    )
  }

  getMember(username: string){
    return this.http.get<Member>(this.baseUrl + 'users/' + username);
  }

}
