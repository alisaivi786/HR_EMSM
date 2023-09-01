import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { DataService } from './shared/DataService';
import { AdminComponent } from './layouts/admin/admin.component';
import { AuthComponent } from './layouts/auth/auth.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthGuard } from './shared/Service/AuthGuard';
import { AuthFooterComponent } from './component/auth-footer/auth-footer.component';
import { DashboardCardComponent } from './component/dashboard-card/dashboard-card.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ApplyLeaveComponent } from './component/apply-leave/apply-leave.component';
import { LeaveTypeMenuComponent } from './component/leave-type-menu/leave-type-menu.component';
import { LeaveNatureMenuComponent } from './component/leave-nature-menu/leave-nature-menu.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchDataComponent,
    AdminComponent,
    AuthComponent,
    AuthFooterComponent,
    DashboardCardComponent,
    ApplyLeaveComponent,
    LeaveTypeMenuComponent,
    LeaveNatureMenuComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    
  ],
  providers: [DataService,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
