﻿// <auto-generated />
using System;
using DesarrolloSocialModelo.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20221213214359__cargaFamilia")]
    partial class _cargaFamilia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFAdolescentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActividadCultural")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<int>("CantidadPersonasaCargo")
                        .HasColumnType("INT")
                        .HasColumnOrder(2);

                    b.Property<string>("Embarazos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EnfermedadDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("Estudia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<int>("IDCargaFamiliar")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<double>("Ingreso")
                        .HasColumnType("FLOAT")
                        .HasColumnOrder(6);

                    b.Property<string>("TienenDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Trabaja")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.ToTable("CargaFAdolescentes");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFAdultos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActividadCultural")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<int>("Cantidad")
                        .HasColumnType("INT")
                        .HasColumnOrder(2);

                    b.Property<string>("Embarazos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EnfermedadDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("Estudia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<int>("IDCargaFamiliar")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<string>("Ingreso")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<string>("TienenDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Trabaja")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.ToTable("CargaFAdultos");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFAdultosMayores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActividadCultural")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<int>("CantidadPersonasAcargo")
                        .HasColumnType("INT")
                        .HasColumnOrder(2);

                    b.Property<string>("Embarazos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EnfermedadDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("Estudia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<int>("IDCargaFamiliar")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<double>("Ingreso")
                        .HasColumnType("FLOAT")
                        .HasColumnOrder(6);

                    b.Property<string>("TienenDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Trabaja")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.ToTable("CargaFAdultosyores");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFJefeDefamilia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActividadCultural")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<int>("CantidadPersonasAcargo")
                        .HasColumnType("INT")
                        .HasColumnOrder(2);

                    b.Property<string>("Embarazos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EnfermedadDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("Estudia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<int>("IDCargaFamiliar")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<double>("Ingreso")
                        .HasColumnType("FLOAT")
                        .HasColumnOrder(6);

                    b.Property<string>("TienenDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Trabaja")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.ToTable("CargaFJefeDefamilia");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFNiños", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ActividadCultural")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<int>("CantidadPersonasACargo")
                        .HasColumnType("INT")
                        .HasColumnOrder(2);

                    b.Property<string>("Embarazos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EnfermedadDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("Estudia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<int>("IDCargaFamiliar")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<double>("Ingreso")
                        .HasColumnType("FLOAT")
                        .HasColumnOrder(6);

                    b.Property<string>("TienenDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Trabaja")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Tratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.ToTable("CargaFNiños");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.CargaFamiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CantidadDepersonasBajosuCargo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(2);

                    b.Property<string>("NiñosEstudian")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.ToTable("CargaFamiliar");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.DatosPrincipalesRG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avenida")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(7);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(17);

                    b.Property<string>("EdifioCasa")
                        .IsRequired()
                        .HasColumnType("VARCHAR (50)")
                        .HasColumnOrder(11);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(2);

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<string>("Numerodecasa")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(13);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("Parroquia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("Piso")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(12);

                    b.Property<int>("PuntodeReferencia")
                        .HasColumnType("INT")
                        .HasColumnOrder(14);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnOrder(15);

                    b.Property<string>("TelefonoAlternativo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(16);

                    b.Property<string>("Urbanizacion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(9);

                    b.HasKey("Id");

                    b.ToTable("DatosPrincipalesRG");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.Gestores", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

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

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(11);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdEstado")
                        .HasColumnType("INT")
                        .HasColumnOrder(10);

                    b.Property<int>("IdRol")
                        .HasColumnType("INT")
                        .HasColumnOrder(14);

                    b.Property<string>("LugarNacimiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(17);

                    b.Property<string>("MunicipioProvincia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(18);

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

                    b.HasKey("Email");

                    b.ToTable("Gestores");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.ResponsabledeFamilia", b =>
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

                    b.Property<int>("CondicionLaboral")
                        .HasColumnType("INT")
                        .HasColumnOrder(15);

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(5);

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(8);

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(10);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(7);

                    b.Property<string>("Habilidades")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(13);

                    b.Property<string>("MediodeTransporte")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(18);

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<string>("NivelInstruccion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(16);

                    b.Property<int>("NiveldeInstruccion")
                        .HasColumnType("INT")
                        .HasColumnOrder(11);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(2);

                    b.Property<string>("NumerodeDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<int>("NumerodeHijos")
                        .HasColumnType("INT")
                        .HasColumnOrder(20);

                    b.Property<int>("PadeceEnfermedad")
                        .HasColumnType("INT")
                        .HasColumnOrder(23);

                    b.Property<string>("Profesion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(12);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(9);

                    b.Property<string>("TieneDiscapacidad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(21);

                    b.Property<string>("TieneHijos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(19);

                    b.Property<string>("Tienetratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(25);

                    b.Property<string>("TipoEnfermedad")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(24);

                    b.Property<int>("TipodeDiscapacidad")
                        .HasColumnType("INT")
                        .HasColumnOrder(22);

                    b.Property<string>("TipodeNegocio")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(17);

                    b.Property<string>("TipodeTratamiento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(26);

                    b.Property<int>("Trabaja")
                        .HasColumnType("INT")
                        .HasColumnOrder(14);

                    b.HasKey("Id");

                    b.ToTable("Responsabledefamilia");
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

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.SoloParaUsoDelGestor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(5);

                    b.Property<string>("NecesidadDelEncuestado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(2);

                    b.Property<string>("NombredelGestor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("NumerodeDocumento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.HasKey("Id");

                    b.ToTable("SoloParaUsoDelGestor");
                });

            modelBuilder.Entity("DesarrolloSocialModelo.DataModel.Vivienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AseguraqueTodosLosDatosIngresadosSonCorrectos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(7);

                    b.Property<string>("CondiciondelaVivienda")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(3);

                    b.Property<string>("RequerimientodelaVivienda")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(4);

                    b.Property<string>("ServiciosBasicosdelaVivienda")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnOrder(6);

                    b.Property<DateTime>("TEnenciadelaVivienda")
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(5);

                    b.Property<string>("TipodeVivienda")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("Vivienda");
                });
#pragma warning restore 612, 618
        }
    }
}
