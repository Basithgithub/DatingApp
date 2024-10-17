import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit{

  Users:any;

  constructor(public http:HttpClient){}

  ngOnInit(): void {
    this.http.get("https://localhost:5001/api/Users").subscribe((x)=> {
       this.Users = x;
    });
  }
}
