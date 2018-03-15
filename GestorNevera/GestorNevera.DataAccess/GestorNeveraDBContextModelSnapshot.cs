﻿// <auto-generated />
using GestorEstudiantil.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GestorEstudiantil.DataAcces.Migrations
{
	[DbContext(typeof(GestorNeveraDBContext))]
	partial class GestorNeveraDBContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("ProductVersion", "2.0.1-rtm-125");

			modelBuilder.Entity("GestorNevera.models.Materiales", b =>
			{
				b.Property<int>("MaterialesId")
					.ValueGeneratedOnAdd();

				b.Property<bool>("Materiales");

				b.Property<int>("PrecioId");

		

				b.HasKey("MaterialesId");

				b.HasIndex("PrecioId");

				b.ToTable("Materiales");
			});

			modelBuilder.Entity("GestorNevera.models.Nevera", b =>
			{
				b.Property<string>("NeveraId")
					.ValueGeneratedOnAdd();

				b.Property<string>("Marca");

				b.Property<int>("Serie");

				b.Property<Ilis>("Precio");

			
			});

			modelBuilder.Entity("GestorNevera.models.Precio", b =>
			{
				b.Property<int>("PrecioId")
					.ValueGeneratedOnAdd();

				b.Property<int>("NeveraId");

				b.Property<string>("NeveraId1");

				

				b.Property<int>("CapacidadId");

				b.HasKey("PrecioId");

				b.HasIndex("NeveraId1");

				b.HasIndex("CapacidadId");

				b.ToTable("Precio");
			});

			modelBuilder.Entity("GestorNevera.models.Marca", b =>
			{
				b.Property<int>("MarcaId")
					.ValueGeneratedOnAdd();

				b.Property<string>("NombreMarca");

				b.Property<Ilist>("Precio");

				b.Property<Ilist>("Capacidad");

				b.HasKey("CapacidadId");

				b.ToTable("Capacidad");

				b.HasKey("PrecioId");

				b.ToTable("Precio");

				b.HasKey("MarcaId");

				b.ToTable("Marca");
			});

			modelBuilder.Entity("GestorNevera.models.Categoria", b =>
			{
				b.Property<int>("SemestreId")
					.ValueGeneratedOnAdd();

				b.Property<string>("NombreSemestre");

				b.HasKey("SemestreId");

				b.ToTable("Semestre");




				b.Property<int>("CategoriaId")
					.ValueGeneratedOnAdd();

				b.Property<string>("NombreCategoria");

				b.Property<Ilist>("Capacidad");

				b.Property<Ilist>("Precio");

				b.HasKey("PrecioId");

				b.ToTable("Precio");

				b.HasKey("CapacidadId");

				b.ToTable("Capacidad");

				b.HasKey("SemestreId");

				b.ToTable("Semestre");

			});

			modelBuilder.Entity("GestorEstudiantil.models.SemestreMateria", b =>
			{
				b.Property<int>("SemestreMateriaId")
					.ValueGeneratedOnAdd();

				b.Property<int>("MateriaId");

				b.Property<int>("SemestreId");

				b.HasKey("SemestreMateriaId");

				b.HasIndex("MateriaId");

				b.HasIndex("SemestreId");

				b.ToTable("SemestreMateria");
			});

			modelBuilder.Entity("GestorNevera.models.Materiales", b =>
			{
				b.HasOne("GestorNevera.models.Precio", "Precio")
					.WithMany("Materiales")
					.HasForeignKey("PrecioId")
					.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity("GestorEstudiantil.models.EstudianteMatriculado", b =>
			{
				b.HasOne("GestorEstudiantil.models.Estudiante", "Estudiante")
					.WithMany("Materia")
					.HasForeignKey("EstudianteId1");

				b.HasOne("GestorEstudiantil.models.SemestreMateria", "SemestreMateria")
					.WithMany("EstudianteMatriculado")
					.HasForeignKey("SemestreMateriaId")
					.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity("GestorNevera.models.Capacidad", b =>
			{
				b.HasOne("GestorNevera.models.Materia", "Marca")
					.WithMany("Marca")
					.HasForeignKey("MarcaId")
					.OnDelete(DeleteBehavior.Cascade);

				b.HasOne("GestorNevera.models.Categoria", "Categoria")
					.WithMany("Marca")
					.HasForeignKey("CategoriaId")
					.OnDelete(DeleteBehavior.Cascade);
			});
#pragma warning restore 612, 618
		}
	}
}