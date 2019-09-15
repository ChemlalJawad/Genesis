﻿// <auto-generated />
using System;
using Genesis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Genesis.Data.Migrations
{
    [DbContext(typeof(GenesisContext))]
    [Migration("20190915132212_jawad3")]
    partial class jawad3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Genesis.Core.Domaine.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EntrepriseId");

                    b.Property<string>("Pays");

                    b.Property<string>("Rue");

                    b.Property<string>("Ville");

                    b.HasKey("Id");

                    b.HasIndex("EntrepriseId");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("Genesis.Core.Domaine.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdresseId");

                    b.Property<string>("NumeroTva");

                    b.Property<int>("TypeContact");

                    b.HasKey("Id");

                    b.HasIndex("AdresseId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Genesis.Core.Domaine.Entreprise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactId");

                    b.Property<string>("NumeroTva");

                    b.Property<int?>("SiegeSocialId");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("SiegeSocialId");

                    b.ToTable("Entreprises");
                });

            modelBuilder.Entity("Genesis.Core.Domaine.Adresse", b =>
                {
                    b.HasOne("Genesis.Core.Domaine.Entreprise")
                        .WithMany("Adresses")
                        .HasForeignKey("EntrepriseId");
                });

            modelBuilder.Entity("Genesis.Core.Domaine.Contact", b =>
                {
                    b.HasOne("Genesis.Core.Domaine.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId");
                });

            modelBuilder.Entity("Genesis.Core.Domaine.Entreprise", b =>
                {
                    b.HasOne("Genesis.Core.Domaine.Contact")
                        .WithMany("Entreprises")
                        .HasForeignKey("ContactId");

                    b.HasOne("Genesis.Core.Domaine.Adresse", "SiegeSocial")
                        .WithMany()
                        .HasForeignKey("SiegeSocialId");
                });
#pragma warning restore 612, 618
        }
    }
}