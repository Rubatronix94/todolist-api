using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todolist_api.Migrations
{
    /// <inheritdoc />
    public partial class TAREAS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tarea = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    completado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_titulo",
                table: "Tareas",
                column: "titulo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
