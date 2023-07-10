﻿// <auto-generated />
using System;
using FIT_Api_Examples.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIT_Api_Examples.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isProdekan")
                        .HasColumnType("bit");

                    b.Property<bool>("isStudentskaSluzba")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_korisnika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.AkademskaGodina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datum_added")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datum_update")
                        .HasColumnType("datetime2");

                    b.Property<int?>("evidentiraoKorisnikid")
                        .HasColumnType("int");

                    b.Property<int?>("izmijenioKorisnikid")
                        .HasColumnType("int");

                    b.Property<string>("opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("evidentiraoKorisnikid");

                    b.HasIndex("izmijenioKorisnikid");

                    b.ToTable("AkademskaGodina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Ispit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIspita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.ToTable("Ispit");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Obavijest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datum_kreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datum_update")
                        .HasColumnType("datetime2");

                    b.Property<int>("evidentiraoKorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("izmijenioKorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("evidentiraoKorisnikID");

                    b.HasIndex("izmijenioKorisnikID");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("drzava_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("drzava_id");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ECTS")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IspitID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IspitID");

                    b.HasIndex("StudentID");

                    b.ToTable("PrijavaIspita");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.UpisanaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("akademskaGodinaid")
                        .HasColumnType("int");

                    b.Property<int?>("akademskaId")
                        .HasColumnType("int");

                    b.Property<float>("cijenaSkolarine")
                        .HasColumnType("real");

                    b.Property<DateTime?>("datumOvjere")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumUpisa")
                        .HasColumnType("datetime2");

                    b.Property<int>("godinaStudija")
                        .HasColumnType("int");

                    b.Property<string>("napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obnova")
                        .HasColumnType("bit");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("akademskaGodinaid");

                    b.HasIndex("studentId");

                    b.ToTable("UpisanaGodina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Nastavnik", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3_MaticnaKnjiga.Models.Student", b =>
                {
                    b.HasBaseType("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("broj_indeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("opstina_rodjenja_id")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("opstina_rodjenja_id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.AkademskaGodina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "evidentiraoKorisnik")
                        .WithMany()
                        .HasForeignKey("evidentiraoKorisnikid");

                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "izmijenioKorisnik")
                        .WithMany()
                        .HasForeignKey("izmijenioKorisnikid");

                    b.Navigation("evidentiraoKorisnik");

                    b.Navigation("izmijenioKorisnik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Ispit", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Predmet", "predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Obavijest", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "evidentiraoKorisnik")
                        .WithMany()
                        .HasForeignKey("evidentiraoKorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", "izmijenioKorisnik")
                        .WithMany()
                        .HasForeignKey("izmijenioKorisnikID");

                    b.Navigation("evidentiraoKorisnik");

                    b.Navigation("izmijenioKorisnik");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzava_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.PrijavaIspita", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Ispit", "Ispit")
                        .WithMany()
                        .HasForeignKey("IspitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul3_MaticnaKnjiga.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ispit");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.UpisanaGodina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.AkademskaGodina", "akademskaGodina")
                        .WithMany()
                        .HasForeignKey("akademskaGodinaid");

                    b.HasOne("FIT_Api_Examples.Modul3_MaticnaKnjiga.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.Navigation("akademskaGodina");

                    b.Navigation("student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Nastavnik", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Examples.Modul2.Models.Nastavnik", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3_MaticnaKnjiga.Models.Student", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FIT_Api_Examples.Modul3_MaticnaKnjiga.Models.Student", "id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul2.Models.Opstina", "opstina_rodjenja")
                        .WithMany()
                        .HasForeignKey("opstina_rodjenja_id");

                    b.Navigation("opstina_rodjenja");
                });
#pragma warning restore 612, 618
        }
    }
}
