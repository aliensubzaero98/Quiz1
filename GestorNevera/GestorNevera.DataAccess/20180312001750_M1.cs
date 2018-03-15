namespace GestorEstudiantil.DataAcces.Migrations
{
	public partial class M1 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Nevera",
				columns: table => new
				{
					NeveraId = table.Column<string>(nullable: false),
					Marca = table.Column<string>(nullable: true),
					Serie = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Nevera", x => x.NeveraId);
				});

			migrationBuilder.CreateTable(
				name: "Marca",
				columns: table => new
				{
					MarcaId = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					NombreMarca = table.Column<string>(nullable: true),
					Capacidad = table.Column<Ilist>(nullable: true),
					Precio = table.Column<Ilist>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Marca", x => x.MarcaId);
				});

			migrationBuilder.CreateTable(
				name: "Categoria",
				columns: table => new
				{
					CategoriaId = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					NombreCategoria = table.Column<string>(nullable: true),
					Capacidad = table.Column<Ilis>(nullable: true),
					Precio = table.Column<Ilist>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
				});

			migrationBuilder.CreateTable(
				name: "Capacidad",
				columns: table => new
				{
					CapacidadId = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					MarcaId = table.Column<int>(nullable: false),
					CategoriaId = table.Column<int>(nullable: false),
					PrecioAsociado = table.Column<Ilis>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Capacidad", x => x.CapacidadId);
					table.ForeignKey(
						name: "FK_Capacidad_Marca_MarcaId",
						column: x => x.MarcaId,
						principalTable: "Marca",
						principalColumn: "MarcaId",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Capacidad_Categoria_CategoriaId",
						column: x => x.CategoriaId,
						principalTable: "Categoria",
						principalColumn: "CategoriaId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Precio",
				columns: table => new
				{
					PrecioId = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					MaterialesId = table.Column<Ilist>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Precio", x => x.PrecioId);
					table.ForeignKey(
						name: "FK_Precio_Nevera_NeveraId1",
						column: x => x.NeveraId1,
						principalTable: "Nevera",
						principalColumn: "NeveraId",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_Precio_Capacidad_CapacidadId",
						column: x => x.CapacidadId,
						principalTable: "SemestreMateria",
						principalColumn: "SemestreMateriaId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Materiales",
				columns: table => new
				{
					MaterialesId = table.Column<int>(nullable: false)
						.Annotation("Sqlite:Autoincrement", true),
					PrecioId = table.Column<bool>(nullable: false)
					
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Materiales", x => x.PrecioId);
					table.ForeignKey(
						name: "FK_Materiales_Precio_PrecioId",
						column: x => x.PrecioId,
						principalTable: "Precio",
						principalColumn: "PrecioId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Materiales_PrecioId",
				table: "Materiales",
				column: "PrecioId");

			migrationBuilder.CreateIndex(
				name: "IX_Precio_NeveraId1",
				table: "Precio",
				column: "NeveraId1");

			migrationBuilder.CreateIndex(
				name: "IX_Precio_CapacidadId",
				table: "Precio",
				column: "CapacidadId");

			migrationBuilder.CreateIndex(
				name: "IX_Capacidad_MarcaId",
				table: "Capacidad",
				column: "MarcaId");

			migrationBuilder.CreateIndex(
				name: "IX_Capacidad_CategoriaId",
				table: "Capacidad",
				column: "CategoriaId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Materiales");

			migrationBuilder.DropTable(
				name: "Precio");

			migrationBuilder.DropTable(
				name: "Nevera");

			migrationBuilder.DropTable(
				name: "Capacidad");

			migrationBuilder.DropTable(
				name: "Marca");

			migrationBuilder.DropTable(
				name: "Categoria");
		}
	}
}