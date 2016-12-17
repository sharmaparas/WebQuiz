import {Injectable} from "@angular/core";
import {Http, Response, Headers, URLSearchParams, QueryEncoder} from '@angular/http';
declare var JSON: any;

@Injectable()
export class UserService {
    private apiUrl = "/api/user/";
    constructor(private http: Http) { }

    getUsers(sortParam, searchQuery): Promise<any> {
        let params = new URLSearchParams();
        params.set('sort', sortParam);
        params.set('query', searchQuery);
        return this.http.get(this.apiUrl, { search: params })
            .toPromise()
            .then(response => response.json());
    }

    filterSortedUsers(sortParam, searchQuery): Promise<any> {
        let params = new URLSearchParams();
        params.set('sort', sortParam);
        params.set('query', searchQuery);
        return this.http.get(this.apiUrl, { search: params })
            .toPromise()
            .then(response => response.json());
    }
}