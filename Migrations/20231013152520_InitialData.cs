using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace proyectoef.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7022"), null, "Actividades Pendientes", 20 },
                    { new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7035"), null, "Actividades Personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7021"), new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7022"), null, new DateTime(2023, 10, 13, 9, 25, 19, 832, DateTimeKind.Local).AddTicks(6408), 1, "Pago de servicios publicos" },
                    { new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7043"), new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7035"), null, new DateTime(2023, 10, 13, 9, 25, 19, 832, DateTimeKind.Local).AddTicks(6424), 0, "Terminar pelicula de Netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7021"));

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7043"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7022"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("ceb7ae06-393c-4c65-9d05-7a81c62d7035"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
