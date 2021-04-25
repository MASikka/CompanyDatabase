using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class _3rdTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyOfficeId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyOfficeId",
                table: "Employee",
                column: "CompanyOfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_CompanyOffice_CompanyOfficeId",
                table: "Employee",
                column: "CompanyOfficeId",
                principalTable: "CompanyOffice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_CompanyOffice_CompanyOfficeId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CompanyOfficeId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CompanyOfficeId",
                table: "Employee");
        }
    }
}
