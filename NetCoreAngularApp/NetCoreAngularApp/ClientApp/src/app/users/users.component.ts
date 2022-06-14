import { Component, OnInit } from "@angular/core";
import { UserDataService } from "../_data-services/user.data-service";

@Component({
  selector: "app-users",
  templateUrl: "./users.component.html",
  styleUrls: ["./users.component.css"],
})
export class UsersComponent implements OnInit {
  users: any[];
  user: any = {};
  showList: boolean = true;

  constructor(private userDataService: UserDataService) {}

  ngOnInit() {
    this.get();
  }

  get() {
    this.userDataService.get().subscribe(
      (data: any[]) => {
        this.users = data;
        this.showList = true;
      },
      (error) => {
        console.log(error);
        alert("Internal Error");
      }
    );
  }

  save() {
   !this.user.id ? this.post() : this.put(); 
  }

  openDetails(user) {
    this.showList = false;
    this.user = user;
  }

  post() {
    this.userDataService.post(this.user).subscribe(
      (data) => {
        if (data) {
          alert("User created successfully");
          this.get();
          this.user = {};
        } else {
          alert("Error creating user");
        }
      },
      (error) => {
        console.log(error);
        alert("Internal Error");
      }
    );
  }

  put() {
    this.userDataService.put(this.user).subscribe(
      (data) => {
        if (data) {
          alert("User updated successfully");
          this.get();
          this.user = {};
        } else {
          alert("Error updating user");
        }
      },
      (error) => {
        console.log(error);
        alert("Internal Error");
      }
    );
  }

  delete(user) {
    this.userDataService.delete(user.id).subscribe(
      (userId) => {
        if (userId) {
          alert("User deleted successfully");
          this.get();
          this.user = {};
        } else {
          alert("Error deleting user");
        }
      },
      (error) => {
        console.log(error);
        alert("Internal Error");
      }
    );
  }
}
