﻿// <auto-generated />
using System;
using DesarrolloSocialModelo.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    [DbContext(typeof(MyAppContext))]
    partial class MyAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.Gestores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<int>("Edad")
                        .HasColumnType("INT")
                        .HasColumnOrder(15);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(11);

                    b.Property<int>("IdEstado")
                        .HasColumnType("INT")
                        .HasColumnOrder(10);

                    b.Property<int>("IdRol")
                        .HasColumnType("INT")
                        .HasColumnOrder(14);

                    b.Property<string>("LugarNacimiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(16);

                    b.Property<string>("MunicioProvincia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(16);

                    b.Property<string>("NivelInstruccion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(16);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(2);

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(13);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(9);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(12);

                    b.HasKey("Id");

                    b.ToTable("Gestores");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.RespuestasDeFormulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(5);

                    b.Property<string>("ConQueFRecuenciaTeHacesUnChequeoMedico")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(10);

                    b.Property<string>("CorreoElectronioco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<DateTime>("MarcaTemporal")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(2);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(4);

                    b.Property<string>("NummeroIdentificacion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(3);

                    b.Property<string>("PadecesDeAlgunaEnfermedadActualmente")
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnOrder(8);

                    b.Property<string>("TienesAlgunaEnfermedadOCondicionHederitaria")
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnOrder(9);

                    b.Property<string>("TienesLasVacunasContraElCovid19")
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.ToTable("RespuestasDeFormulario");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
