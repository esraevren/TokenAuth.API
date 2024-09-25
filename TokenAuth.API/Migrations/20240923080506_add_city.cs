﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TokenAuth.API.Migrations
{
    /// <inheritdoc />
    public partial class add_city : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "City",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");
        }
    }
}
