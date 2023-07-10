import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MojConfig } from '../moj-config';
import { HttpClient } from '@angular/common/http';

declare function porukaSuccess(a: string): any;
declare function porukaError(a: string): any;

@Component({
  selector: 'app-student-maticnaknjiga',
  templateUrl: './student-maticnaknjiga.component.html',
  styleUrls: ['./student-maticnaknjiga.component.css'],
})
export class StudentMaticnaknjigaComponent implements OnInit {
  studentId: number;
  student: any;
  open: boolean = false;
  datumUpisa: any;
  cijena: any;
  akdemskaId: number;
  obnova: boolean;
  godina: any;
  akademske: any;
  upisane: any;
  isOvjera: boolean = false;
  napomena: string;
  datumOvjere: any;
  naslov: string;
  upisanaId: number;
  constructor(private httpKlijent: HttpClient, private route: ActivatedRoute) {}
  loadStudent() {
    this.httpKlijent
      .get(MojConfig.adresa_servera + '/Student/GetById?id=' + this.studentId)
      .subscribe((res) => {
        if (!!res) {
          this.student = res;
        }
      });
  }
  openClose() {
    this.open = !this.open;
  }

  loadAkademske() {
    this.httpKlijent
      .get(MojConfig.adresa_servera + '/AkademskeGodine/GetAll_ForCmb')
      .subscribe((res) => {
        if (!!res) {
          this.akademske = res;
        }
      });
  }
  loadUpisane() {
    this.httpKlijent
      .get(MojConfig.adresa_servera + '/api/UpisanaGodina?id=' + this.studentId)
      .subscribe((res) => {
        if (!!res) {
          this.upisane = res;
        }
      });
  }
  upisSemestra() {
    this.isOvjera = false;
    this.naslov = 'Novi semestar za';
    this.openClose();
  }
  upisiZimski() {
    const body = {
      studentId: this.studentId,
      akademskaId: this.akdemskaId,
      obnova: this.obnova,
      cijenaSkolarine: this.cijena,
      datumUpisa: this.datumUpisa,
      godinaStudija: this.godina,
    };
    this.httpKlijent
      .post(MojConfig.adresa_servera + '/api/UpisanaGodina', body)
      .subscribe((res) => {
        if (!!res) {
          porukaSuccess('Uspjesno upisano');
          this.loadUpisane();
          this.openClose();
        }
      });
  }
  ovjeriZimski(id: number) {
    this.naslov = 'Ovjera semestra za';
    this.isOvjera = true;
    this.openClose();
    this.upisanaId = id;
    console.log(this.upisanaId);
  }
  ovjeri() {
    console.log('test');

    const body = {
      id: this.upisanaId,
      napomena: this.napomena,
      datumOvjere: this.datumOvjere,
    };
    this.httpKlijent
      .put(
        MojConfig.adresa_servera + '/api/UpisanaGodina',
        { ...body },
        MojConfig.http_opcije()
      )
      .subscribe((res) => {
        if (!!res) {
          porukaSuccess('Uspjesno ovjereno!');
          this.loadUpisane();
          this.upisanaId = 0;
          this.openClose();
        } else porukaError('Greska kod ovjeravanja!');
      });
  }
  saveChanges = () => (this.isOvjera ? this.ovjeri() : this.upisiZimski());
  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      this.studentId = +params['id'];
      this.loadStudent();
      this.loadAkademske();
      this.loadUpisane();
    });
  }
}
