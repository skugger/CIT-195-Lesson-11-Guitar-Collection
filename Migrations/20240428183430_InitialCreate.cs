using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIT_195_Lesson_11_Guitar_Collection.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guitar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<DateOnly>(type: "date", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumStrings = table.Column<int>(type: "int", nullable: false),
                    BodyStyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumFrets = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitar");
        }
    }
}
