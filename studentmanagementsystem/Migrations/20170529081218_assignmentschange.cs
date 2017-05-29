using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace studentmanagementsystem.Migrations
{
    public partial class assignmentschange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Assignments",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Subject",
                table: "Assignments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
