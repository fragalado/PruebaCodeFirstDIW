﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231025165537_version2")]
    partial class version2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DAL.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("DAL.Prueba", b =>
                {
                    b.Property<int>("Id_prueba")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id_prueba"));

                    b.Property<int>("EmpleadosId")
                        .HasColumnType("integer");

                    b.Property<int>("Id_empleado")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id_prueba");

                    b.HasIndex("EmpleadosId");

                    b.ToTable("Pruebas");
                });

            modelBuilder.Entity("DAL.Prueba", b =>
                {
                    b.HasOne("DAL.Empleado", "Empleados")
                        .WithMany("Pruebas")
                        .HasForeignKey("EmpleadosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("DAL.Empleado", b =>
                {
                    b.Navigation("Pruebas");
                });
#pragma warning restore 612, 618
        }
    }
}
