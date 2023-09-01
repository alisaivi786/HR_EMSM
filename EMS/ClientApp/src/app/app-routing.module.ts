import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AuthComponent } from './layouts/auth/auth.component';
import { AdminComponent } from './layouts/admin/admin.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AuthGuard } from './shared/Service/AuthGuard';
import { ApplyLeaveComponent } from './component/apply-leave/apply-leave.component';



const routes: Routes = [
  { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthGuard] },
  { path: 'login', component: AuthComponent, pathMatch: 'full' },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
  { path: 'apply-leave', component: ApplyLeaveComponent, canActivate: [AuthGuard] },
  { path: '', component: AdminComponent, canActivate: [AuthGuard] },
];


@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
