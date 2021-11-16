import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PeopleListComponent } from './components/people-list/people-list.component';

import { HttpClientModule } from '@angular/common/http';
import { PersonaService } from './services/persona.service';
import { PeopleSaveComponent } from './components/people-save/people-save.component';

@NgModule({
  declarations: [
    AppComponent,
    PeopleListComponent,
    PeopleSaveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    PersonaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
