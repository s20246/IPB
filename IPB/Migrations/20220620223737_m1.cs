using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IPB.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Telephone",
                columns: table => new
                {
                    IdTelephone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Telephone_pk", x => x.IdTelephone);
                });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "IdTelephone", "Brand", "Model", "ReleaseDate" },
                values: new object[] { 1, "Nokia", "nokia 50", new DateTime(2020, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "IdTelephone", "Brand", "Model", "ReleaseDate" },
                values: new object[] { 2, "Apple", "iPhone X", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Telephone",
                columns: new[] { "IdTelephone", "Brand", "Model", "ReleaseDate" },
                values: new object[] { 3, "Samsung", "Galaxy s9", new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telephone");
        }
    }
}
