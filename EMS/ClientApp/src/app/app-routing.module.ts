import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthComponent } from './views/auth/auth.component';
import { LeaveDataComponent } from './views/leave-data/leave-data.component';
import { AuthGuard } from './shared/AuthGuard';
import { ApplyLeaveComponent } from './component/apply-leave/apply-leave.component';
import { HomePageComponent } from './views/home-page/home-page.component';
import { DashboardComponent } from './views/dashboard/dashboard.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { AppLayoutComponent } from './layouts/app-layout/app-layout.component';



const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: AuthLayoutComponent },
  { path: '', component: AppLayoutComponent, canActivate: [AuthGuard],
    children: [
      { path: 'dashboard', component: DashboardComponent },
      { path: 'home-page', component: HomePageComponent },
      { path: 'leave-data', component: LeaveDataComponent },
      { path: 'apply-leave', component: ApplyLeaveComponent },
      
      // Add more routes for the main application here
    ],
  },
  // Add any other routes here, like a "404 Not Found" page
];


@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
