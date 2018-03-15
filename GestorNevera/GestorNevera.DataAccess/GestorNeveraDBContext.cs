using GestorNevera.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestorNevera.DataAccess
{
	public class GestorNeveraDBContext
	{
		public DbSet<Categoria> Categoria { get; set; }
		public DbSet<Capacidad> Capacidad { get; set; }
		public DbSet<Marca> Marca { get; set; }
		public DbSet<Materiales> Materiales { get; set; }
		public DbSet<Nevera> Nevera { get; set; }
		public DbSet<Precio> Precio { get; set; }


		public GestorNeveraDBContext(DbContextOptions<GestorNeveraDBContext> options) : base(options)
		{

		}

		protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlite("Data Sourc=gestorNevera.db");
		}



	}
}
