import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './component/nav-menu/nav-menu.component';
import { DashboardComponent } from './views/dashboard/dashboard.component';
import { LeaveDataComponent } from './views/leave-data/leave-data.component';
import { AuthComponent } from './views/auth/auth.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthGuard } from './shared/AuthGuard';
import { AuthFooterComponent } from './component/auth-footer/auth-footer.component';
import { DashboardCardComponent } from './component/dashboard-card/dashboard-card.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ApplyLeaveComponent } from './component/apply-leave/apply-leave.component';
import { ApiService } from './Services/ApiService';
import { LeaveService } from './Services/LeaveService';
import { DashboardService } from './Services/DashboardService';
import { HomePageComponent } from './views/home-page/home-page.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { AppLayoutComponent } from './layouts/app-layout/app-layout.component';
import { AuthInterceptor } from './Services/AuthInterceptor';
import { LeaveTypeDropdownComponent } from './component/leave-type-dropdown/leave-type-dropdown.component';
import { LeaveNatureDropdownComponent } from './component/leave-nature-dropdown/leave-nature-dropdown.component';
import { LeaveNatureService } from './Services/LeaveNature';
import { LeaveTypeService } from './Services/LeaveTypeService';
import { PieChartComponent } from './component/pie-chart/pie-chart.component';
import { NgChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    DashboardComponent,
    LeaveDataComponent,
    AuthComponent,
    AuthFooterComponent,
    DashboardCardComponent,
    ApplyLeaveComponent,
    HomePageComponent,
    AuthLayoutComponent,
    AppLayoutComponent,
    LeaveTypeDropdownComponent,
    LeaveNatureDropdownComponent,
    PieChartComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    NgChartsModule
    
  ],
  providers: [AuthGuard,ApiService,LeaveService,DashboardService,
    {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  },
  LeaveNatureService,
  LeaveTypeService

],
  bootstrap: [AppComponent]
})
export class AppModule { }
