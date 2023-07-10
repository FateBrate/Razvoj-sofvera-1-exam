import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { MojConfig } from '../moj-config';
import { Router } from '@angular/router';
declare function porukaSuccess(a: string): any;
declare function porukaError(a: string): any;

@Component({
  selector: 'app-studenti',
  templateUrl: './studenti.component.html',
  styleUrls: ['./studenti.component.css'],
})
export class StudentiComponent implements OnInit {
  title: string = 'angularFIT2';
  ime_prezime: string = '';
  opstina: string = '';
  studentPodaci: any;
  filter_ime_prezime: boolean;
  filter_opstina: boolean;
  student: any;
  open: boolean = false;
  opstine: any;
  def_opstina_id: number;
  naslov: string;
  openClose() {
    this.open = !this.open;
  }
  odaberiStudenta() {
    this.naslov = 'Dodaj student';
    this.openClose();
    this.student = {
      ime: this.ime_prezime,
      prezime: '',
      opstina_rodjenja_id: this.def_opstina_id,
    };
  }

  constructor(private httpKlijent: HttpClient, private router: Router) {}
  filtriraj() {
    const params = new HttpParams()
      .set('ime_prezime', this.ime_prezime)
      .set('opstina', this.opstina);
    this.testirajWebApi(params);
  }
  Obrisi(id: number) {
    this.httpKlijent
      .delete(MojConfig.adresa_servera + '/Student/Delete?id=' + id)
      .subscribe((res) => {
        if (!!res) {
          porukaSuccess('student uspjesno obrisan');
          this.testirajWebApi();
        }
      });
  }
  toMaticna(id: number) {
    this.router.navigate(['student-maticnaknjiga', id]);
  }
  SaveChanges() {
    this.httpKlijent
      .post(MojConfig.adresa_servera + '/Student/Add', this.student)
      .subscribe((res) => {
        if (!!res) {
          this.openClose();
          porukaSuccess('Uspjesno dodan student');
          this.testirajWebApi();
        }
      });
  }
  loadOpstine() {
    this.httpKlijent
      .get(MojConfig.adresa_servera + '/Opstina/GetByAll')
      .subscribe((res) => {
        if (!!res) {
          this.opstine = res;
        }
      });
  }
  testirajWebApi(params?: HttpParams): void {
    this.httpKlijent
      .get(MojConfig.adresa_servera + '/Student/GetAll', { params })
      .subscribe((x) => {
        this.studentPodaci = x;
        //za defaultnu opstina
        if (Array.isArray(x)) {
          this.def_opstina_id = x[0].opstina_rodjenja_id;
        }
      });
  }
  urediStudenta() {
    this.naslov = 'Edit student';
    this.openClose();
  }
  ngOnInit(): void {
    this.testirajWebApi();
    this.loadOpstine();
  }
}
