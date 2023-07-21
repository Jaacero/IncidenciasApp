using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TiposEmail",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Email Personal" },
                    { 2, "Email Laboral" }
                });

            migrationBuilder.InsertData(
                table: "TiposTelefono",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Telefono Personal" },
                    { 2, "Telefono Empresarial" },
                    { 3, "Telefono Fijo" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pedro Carvajal" },
                    { 2, "Marcelo Benedetti" },
                    { 3, "Alicia Romero" }
                });

            migrationBuilder.InsertData(
                table: "EmailsTrainer",
                columns: new[] { "IdTipoEmail", "IdTrainer", "Email" },
                values: new object[,]
                {
                    { 1, 1, "pedro123@gmail.com" },
                    { 1, 2, "pedro@gmail.com" },
                    { 1, 3, "Aicia@gmail.com" },
                    { 2, 1, "pedro_work@gmail.com" },
                    { 2, 2, "marcelo_work@gmail.com" },
                    { 2, 3, "Aicia_work@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "TelefonosTrainer",
                columns: new[] { "IdTipoTelefono", "IdTrainer", "NumeroTelefono" },
                values: new object[,]
                {
                    { 2, 1, "300254214" },
                    { 2, 2, "315246325" },
                    { 2, 3, "3213383473" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmailsTrainer",
                keyColumns: new[] { "IdTipoEmail", "IdTrainer" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "TelefonosTrainer",
                keyColumns: new[] { "IdTipoTelefono", "IdTrainer" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TelefonosTrainer",
                keyColumns: new[] { "IdTipoTelefono", "IdTrainer" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TelefonosTrainer",
                keyColumns: new[] { "IdTipoTelefono", "IdTrainer" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "TiposTelefono",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposTelefono",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposEmail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposEmail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposTelefono",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
