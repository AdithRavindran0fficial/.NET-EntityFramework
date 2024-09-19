using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_4_EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Name = table.Column<int>(type: "int", nullable: false),
                    Employee_Sal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Joining = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Emp_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
