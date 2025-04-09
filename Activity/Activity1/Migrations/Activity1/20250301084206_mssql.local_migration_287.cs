using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Activity1.Migrations.Activity1
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_287 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Petname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetBredd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
