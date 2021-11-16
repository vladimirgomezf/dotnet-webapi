import { Component, OnInit, OnDestroy } from '@angular/core';
import { Persona } from 'src/app/domain/persona';
import { PersonaService } from 'src/app/services/persona.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-people-list',
  templateUrl: './people-list.component.html',
  styleUrls: ['./people-list.component.css'],
})
export class PeopleListComponent implements OnInit, OnDestroy {
  public persona: Persona[];
  public subPersona: Subscription;

  constructor(public personaService: PersonaService) {
    this.persona = [];
    this.subPersona = new Subscription();
  }

  ngOnDestroy(): void {
    this.subPersona.unsubscribe();
  }

  ngOnInit(): void {
    this.getAll();
  }

  getAll() {
    this.subPersona = this.personaService.getAll().subscribe(data => {
      this.persona = data;
    });
  }
}
