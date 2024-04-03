using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myAplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manegers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passward = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numbrb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manegers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    passward = table.Column<int>(type: "int", nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumOfChildrenc = table.Column<int>(type: "int", nullable: false),
                    IsRevachaFamily = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<float>(type: "real", nullable: false),
                    NumOfDarga = table.Column<int>(type: "int", nullable: false),
                    IsRevacha = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirthday = table.Column<DateOnly>(type: "date", nullable: false),
                    MotherHelper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_parents_Parentid",
                        column: x => x.Parentid,
                        principalTable: "parents",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_Parentid",
                table: "Children",
                column: "Parentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "manegers");

            migrationBuilder.DropTable(
                name: "parents");
        }
    }
}
