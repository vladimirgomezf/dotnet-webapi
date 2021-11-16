import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PeopleListComponent } from './components/people-list/people-list.component';
import { PeopleSaveComponent } from './components/people-save/people-save.component';

const routes: Routes = [
  {path: "people-list", component: PeopleListComponent},
  {path: "people-save", component: PeopleSaveComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
