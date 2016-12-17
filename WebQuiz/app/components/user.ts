import { Component, OnInit } from "@angular/core";
import { UserService } from "../services/UserService"
import { FormsModule } from "@angular/forms";


@Component({
    selector: "profile-component",
    templateUrl: "/partial/user",
    providers: [UserService]
})

export class UserProfileComponent implements OnInit {
    constructor(private userService: UserService) { }
    public arr: any;
    public search: string;
    public sort: string;

    ngOnInit(): void {
        this.search = "";
        this.sort = "ID";
        this.userService.getUsers(this.sort, this.search).then(response => this.arr = response);
    }

    filterUsers(): void {
        this.userService.filterSortedUsers(this.sort, this.search).then(response => this.arr = response);
    }
}