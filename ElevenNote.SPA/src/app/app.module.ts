import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

//  Services
import { AuthService } from './services/auth.service';

//  Material Components
import 'hammerjs';
import { MatToolbarModule,
         MatButtonModule } from '@angular/material';

//  import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

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
