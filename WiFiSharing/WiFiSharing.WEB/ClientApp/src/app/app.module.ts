import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { SignInComponent } from './components/authorization/sign-in/sign-in.component';
import { SignUpComponent } from './components/authorization/sign-up/sign-up.component';

import { NgxMaskModule, IConfig } from 'ngx-mask';
import { HomeComponent } from './components/home/home.component'
import { MainComponent } from './components/main/main.component';
import { DetailsInfoComponent } from './components/details-info/details-info.component';

const appRoutes: Routes = [
  {
    path: '',
    component: MainComponent,
    children: [
      {
        path: 'home',
        component: HomeComponent
      },
      {
        path: 'details-info',
        component: DetailsInfoComponent
      }
    ]
  },
  { path: 'sign-in', component: SignInComponent },
  { path: 'sign-up', component: SignUpComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    MainComponent,
    SignInComponent,
    SignUpComponent,
    HomeComponent,
    DetailsInfoComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true }
    ),
    NgxMaskModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
