import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Persona } from 'src/app/domain/persona';
import { PersonaService } from 'src/app/services/persona.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-people-save',
  templateUrl: './people-save.component.html',
  styleUrls: ['./people-save.component.css']
})
export class PeopleSaveComponent implements OnInit {

  public persona: Persona;

  public showMsg: Boolean = false;
  public msg: string = '';
  public type: string = '';

  constructor(public personaService: PersonaService, private router: Router) {
    this.persona = new Persona(0,'',0);
   }

  ngOnInit(): void {
    this.persona = new Persona(0,'',0);
  }

  save(){
    console.log(this.persona);

    this.personaService.save(this.persona).subscribe({
      next: () => this.router.navigate(['/people-list']),
      error: (e) => {
        console.log(e);
        this.showMsg = true;
        this.msg = 'An error has occurred in the procedure...'
        this.type = 'danger';
      },
    });
  }

}
