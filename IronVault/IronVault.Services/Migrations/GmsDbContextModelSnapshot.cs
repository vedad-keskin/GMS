﻿// <auto-generated />
using System;
using IronVault.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IronVault.Services.Migrations
{
    [DbContext(typeof(GmsDbContext))]
    partial class GmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IronVault.Services.Database.Aktivnost", b =>
                {
                    b.Property<int>("AktivnostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AktivnostID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AktivnostId"));

                    b.Property<DateTime?>("DatumVrijemeIzlaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVrijemeUlaska")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int")
                        .HasColumnName("TeretanaID");

                    b.HasKey("AktivnostId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Aktivnost_KorisnikID");

                    b.HasIndex(new[] { "TeretanaId" }, "IX_Aktivnost_TeretanaID");

                    b.ToTable("Aktivnost", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Clanarina", b =>
                {
                    b.Property<int>("ClanarinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClanarinaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClanarinaId"));

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanarinaId");

                    b.ToTable("Clanarina", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Dobavljac", b =>
                {
                    b.Property<int>("DobavljacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DobavljacID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DobavljacId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DobavljacId");

                    b.ToTable("Dobavljac", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Faq", b =>
                {
                    b.Property<int>("Faqid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FAQID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Faqid"));

                    b.Property<string>("Odgovor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pitanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Faqid");

                    b.ToTable("FAQ", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradId");

                    b.ToTable("Grad", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategorijaId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikId"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Razina")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("SpolId")
                        .HasColumnType("int")
                        .HasColumnName("SpolID");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int")
                        .HasColumnName("TeretanaID");

                    b.Property<float>("Tezina")
                        .HasColumnType("real");

                    b.Property<float>("Visina")
                        .HasColumnType("real");

                    b.Property<TimeSpan?>("VrijemeUteretani")
                        .HasColumnType("time")
                        .HasColumnName("VrijemeUTeretani");

                    b.HasKey("KorisnikId");

                    b.HasIndex(new[] { "GradId" }, "IX_Korisnik_GradID");

                    b.HasIndex(new[] { "SpolId" }, "IX_Korisnik_SpolID");

                    b.HasIndex(new[] { "TeretanaId" }, "IX_Korisnik_TeretanaID");

                    b.ToTable("Korisnik", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikClanarina", b =>
                {
                    b.Property<int>("KorisnikClanarinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Korisnik_ClanarinaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikClanarinaId"));

                    b.Property<int>("ClanarinaId")
                        .HasColumnType("int")
                        .HasColumnName("ClanarinaID");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.HasKey("KorisnikClanarinaId");

                    b.HasIndex(new[] { "ClanarinaId" }, "IX_Korisnik_Clanarina_ClanarinaID");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Korisnik_Clanarina_KorisnikID");

                    b.ToTable("Korisnik_Clanarina", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikNutricionst", b =>
                {
                    b.Property<int>("KorisnikNutricionistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Korisnik_NutricionistID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikNutricionistId"));

                    b.Property<DateTime>("DatumTermina")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("NutricionistId")
                        .HasColumnType("int")
                        .HasColumnName("NutricionistID");

                    b.Property<int>("ZakazanoSati")
                        .HasColumnType("int");

                    b.HasKey("KorisnikNutricionistId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Korisnik_Nutricionst_KorisnikID");

                    b.HasIndex(new[] { "NutricionistId" }, "IX_Korisnik_Nutricionst_NutricionistID");

                    b.ToTable("Korisnik_Nutricionst", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikSuplement", b =>
                {
                    b.Property<int>("KorisnikSuplementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Korisnik_SuplementID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikSuplementId"));

                    b.Property<DateTime>("DatumVrijemeNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Isporuceno")
                        .HasColumnType("bit");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("SuplementId")
                        .HasColumnType("int")
                        .HasColumnName("SuplementID");

                    b.HasKey("KorisnikSuplementId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Korisnik_Suplement_KorisnikID");

                    b.HasIndex(new[] { "SuplementId" }, "IX_Korisnik_Suplement_SuplementID");

                    b.ToTable("Korisnik_Suplement", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikTrener", b =>
                {
                    b.Property<int>("KorisnikTrenerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Korisnik_TrenerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikTrenerId"));

                    b.Property<DateTime>("DatumTermina")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("TrenerId")
                        .HasColumnType("int")
                        .HasColumnName("TrenerID");

                    b.Property<int>("ZakazanoSati")
                        .HasColumnType("int");

                    b.HasKey("KorisnikTrenerId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Korisnik_Trener_KorisnikID");

                    b.HasIndex(new[] { "TrenerId" }, "IX_Korisnik_Trener_TrenerID");

                    b.ToTable("Korisnik_Trener", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Korisnik_UlogaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogaId"));

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int")
                        .HasColumnName("UlogaID");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Korisnik_Uloga_KorisnikID");

                    b.HasIndex(new[] { "UlogaId" }, "IX_Korisnik_Uloga_UlogaID");

                    b.ToTable("Korisnik_Uloga", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Nutricionist", b =>
                {
                    b.Property<int>("NutricionistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NutricionistID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutricionistId"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("NutricionistId");

                    b.ToTable("Nutricionist", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.NutricionistSeminar", b =>
                {
                    b.Property<int>("NutricionistSeminarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Nutricionist_SeminarID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutricionistSeminarId"));

                    b.Property<int>("NutricionistId")
                        .HasColumnType("int")
                        .HasColumnName("NutricionistID");

                    b.Property<int>("SeminarId")
                        .HasColumnType("int")
                        .HasColumnName("SeminarID");

                    b.HasKey("NutricionistSeminarId");

                    b.HasIndex(new[] { "NutricionistId" }, "IX_Nutricionist_Seminar_NutricionistID");

                    b.HasIndex(new[] { "SeminarId" }, "IX_Nutricionist_Seminar_SeminarID");

                    b.ToTable("Nutricionist_Seminar", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Recenzija", b =>
                {
                    b.Property<int>("RecenzijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RecenzijaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecenzijaId"));

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuplementId")
                        .HasColumnType("int")
                        .HasColumnName("SuplementID");

                    b.HasKey("RecenzijaId");

                    b.HasIndex(new[] { "KorisnikId" }, "IX_Recenzija_KorisnikID");

                    b.HasIndex(new[] { "SuplementId" }, "IX_Recenzija_SuplementID");

                    b.ToTable("Recenzija", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Seminar", b =>
                {
                    b.Property<int>("SeminarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SeminarID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeminarId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Predavac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeminarId");

                    b.ToTable("Seminar", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Spol", b =>
                {
                    b.Property<int>("SpolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SpolID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpolId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpolId");

                    b.ToTable("Spol", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Suplement", b =>
                {
                    b.Property<int>("SuplementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SuplementID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuplementId"));

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int>("DobavljacId")
                        .HasColumnType("int")
                        .HasColumnName("DobavljacID");

                    b.Property<float>("Gramaza")
                        .HasColumnType("real");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int")
                        .HasColumnName("KategorijaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ProsjecnaOcjena")
                        .HasColumnType("float");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StateMachine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuplementId");

                    b.HasIndex(new[] { "DobavljacId" }, "IX_Suplement_DobavljacID");

                    b.HasIndex(new[] { "KategorijaId" }, "IX_Suplement_KategorijaID");

                    b.ToTable("Suplement", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Teretana", b =>
                {
                    b.Property<int>("TeretanaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TeretanaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeretanaId"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("GradID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeretanaId");

                    b.HasIndex(new[] { "GradId" }, "IX_Teretana_GradID");

                    b.ToTable("Teretana", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Trener", b =>
                {
                    b.Property<int>("TrenerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TrenerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrenerId"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("TrenerId");

                    b.ToTable("Trener", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.TrenerSeminar", b =>
                {
                    b.Property<int>("TrenerSeminarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Trener_SeminarID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrenerSeminarId"));

                    b.Property<int>("SeminarId")
                        .HasColumnType("int")
                        .HasColumnName("SeminarID");

                    b.Property<int>("TrenerId")
                        .HasColumnType("int")
                        .HasColumnName("TrenerID");

                    b.HasKey("TrenerSeminarId");

                    b.HasIndex(new[] { "SeminarId" }, "IX_Trener_Seminar_SeminarID");

                    b.HasIndex(new[] { "TrenerId" }, "IX_Trener_Seminar_TrenerID");

                    b.ToTable("Trener_Seminar", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UlogaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga", (string)null);
                });

            modelBuilder.Entity("IronVault.Services.Database.Aktivnost", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Aktivnosts")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Teretana", "Teretana")
                        .WithMany("Aktivnosts")
                        .HasForeignKey("TeretanaId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Teretana");
                });

            modelBuilder.Entity("IronVault.Services.Database.Korisnik", b =>
                {
                    b.HasOne("IronVault.Services.Database.Grad", "Grad")
                        .WithMany("Korisniks")
                        .HasForeignKey("GradId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Spol", "Spol")
                        .WithMany("Korisniks")
                        .HasForeignKey("SpolId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Teretana", "Teretana")
                        .WithMany("Korisniks")
                        .HasForeignKey("TeretanaId")
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Spol");

                    b.Navigation("Teretana");
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikClanarina", b =>
                {
                    b.HasOne("IronVault.Services.Database.Clanarina", "Clanarina")
                        .WithMany("KorisnikClanarinas")
                        .HasForeignKey("ClanarinaId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikClanarinas")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.Navigation("Clanarina");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikNutricionst", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikNutricionsts")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Nutricionist", "Nutricionist")
                        .WithMany("KorisnikNutricionsts")
                        .HasForeignKey("NutricionistId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Nutricionist");
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikSuplement", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikSuplements")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Suplement", "Suplement")
                        .WithMany("KorisnikSuplements")
                        .HasForeignKey("SuplementId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Suplement");
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikTrener", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikTreners")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Trener", "Trener")
                        .WithMany("KorisnikTreners")
                        .HasForeignKey("TrenerId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("IronVault.Services.Database.KorisnikUloga", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUlogas")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUlogas")
                        .HasForeignKey("UlogaId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("IronVault.Services.Database.NutricionistSeminar", b =>
                {
                    b.HasOne("IronVault.Services.Database.Nutricionist", "Nutricionist")
                        .WithMany("NutricionistSeminars")
                        .HasForeignKey("NutricionistId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Seminar", "Seminar")
                        .WithMany("NutricionistSeminars")
                        .HasForeignKey("SeminarId")
                        .IsRequired();

                    b.Navigation("Nutricionist");

                    b.Navigation("Seminar");
                });

            modelBuilder.Entity("IronVault.Services.Database.Recenzija", b =>
                {
                    b.HasOne("IronVault.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Recenzijas")
                        .HasForeignKey("KorisnikId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Suplement", "Suplement")
                        .WithMany("Recenzijas")
                        .HasForeignKey("SuplementId")
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Suplement");
                });

            modelBuilder.Entity("IronVault.Services.Database.Suplement", b =>
                {
                    b.HasOne("IronVault.Services.Database.Dobavljac", "Dobavljac")
                        .WithMany("Suplements")
                        .HasForeignKey("DobavljacId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Kategorija", "Kategorija")
                        .WithMany("Suplements")
                        .HasForeignKey("KategorijaId")
                        .IsRequired();

                    b.Navigation("Dobavljac");

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("IronVault.Services.Database.Teretana", b =>
                {
                    b.HasOne("IronVault.Services.Database.Grad", "Grad")
                        .WithMany("Teretanas")
                        .HasForeignKey("GradId")
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("IronVault.Services.Database.TrenerSeminar", b =>
                {
                    b.HasOne("IronVault.Services.Database.Seminar", "Seminar")
                        .WithMany("TrenerSeminars")
                        .HasForeignKey("SeminarId")
                        .IsRequired();

                    b.HasOne("IronVault.Services.Database.Trener", "Trener")
                        .WithMany("TrenerSeminars")
                        .HasForeignKey("TrenerId")
                        .IsRequired();

                    b.Navigation("Seminar");

                    b.Navigation("Trener");
                });

            modelBuilder.Entity("IronVault.Services.Database.Clanarina", b =>
                {
                    b.Navigation("KorisnikClanarinas");
                });

            modelBuilder.Entity("IronVault.Services.Database.Dobavljac", b =>
                {
                    b.Navigation("Suplements");
                });

            modelBuilder.Entity("IronVault.Services.Database.Grad", b =>
                {
                    b.Navigation("Korisniks");

                    b.Navigation("Teretanas");
                });

            modelBuilder.Entity("IronVault.Services.Database.Kategorija", b =>
                {
                    b.Navigation("Suplements");
                });

            modelBuilder.Entity("IronVault.Services.Database.Korisnik", b =>
                {
                    b.Navigation("Aktivnosts");

                    b.Navigation("KorisnikClanarinas");

                    b.Navigation("KorisnikNutricionsts");

                    b.Navigation("KorisnikSuplements");

                    b.Navigation("KorisnikTreners");

                    b.Navigation("KorisnikUlogas");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("IronVault.Services.Database.Nutricionist", b =>
                {
                    b.Navigation("KorisnikNutricionsts");

                    b.Navigation("NutricionistSeminars");
                });

            modelBuilder.Entity("IronVault.Services.Database.Seminar", b =>
                {
                    b.Navigation("NutricionistSeminars");

                    b.Navigation("TrenerSeminars");
                });

            modelBuilder.Entity("IronVault.Services.Database.Spol", b =>
                {
                    b.Navigation("Korisniks");
                });

            modelBuilder.Entity("IronVault.Services.Database.Suplement", b =>
                {
                    b.Navigation("KorisnikSuplements");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("IronVault.Services.Database.Teretana", b =>
                {
                    b.Navigation("Aktivnosts");

                    b.Navigation("Korisniks");
                });

            modelBuilder.Entity("IronVault.Services.Database.Trener", b =>
                {
                    b.Navigation("KorisnikTreners");

                    b.Navigation("TrenerSeminars");
                });

            modelBuilder.Entity("IronVault.Services.Database.Uloga", b =>
                {
                    b.Navigation("KorisnikUlogas");
                });
#pragma warning restore 612, 618
        }
    }
}