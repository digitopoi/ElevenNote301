import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

//  Services
import { AuthService } from './services/auth.service';

//  Material Components
import 'hammerjs';
import { MatToolbarModule,
         MatFormFieldModule,
         MatInputModule,
         MatButtonModule } from '@angular/material';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//  Components
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { RegisterComponent } from './components/register/register.component';

const routes = [
  { path: 'register', component: RegisterComponent },
  { path: '**', component: RegisterComponent }
];


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes),
    FormsModule,
    ReactiveFormsModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatInputModule
  ],
  providers: [
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
