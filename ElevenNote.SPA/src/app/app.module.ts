import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

//  Services
import { AuthService } from './services/auth.service';

//  Material Components
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material';
import 'hammerjs';

//  Components
import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
