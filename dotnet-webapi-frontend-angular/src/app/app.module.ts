import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { PersonaService } from './services/persona.service';
import { PeopleListComponent } from './components/people-list/people-list.component';
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
    HttpClientModule,
    FormsModule
  ],
  providers: [
    PersonaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
