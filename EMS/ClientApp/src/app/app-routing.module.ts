import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AuthComponent } from './layouts/auth/auth.component';
import { AdminComponent } from './layouts/admin/admin.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';



const routes: Routes = [
  //{ path: '', component: HomeComponent },
  //{ path: 'login', component: AuthComponent },
  // Add more routes as needed
  // { path: '**', redirectTo: '' }, // Redirect to the home page for any other route
  // admin views
 
  { path: "fetch-data", component: FetchDataComponent },
  { path: 'login', component: AuthComponent, pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: '', component: AdminComponent },

];


@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
