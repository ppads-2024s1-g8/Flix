using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Persistence.Data.Migrations
{
    public partial class RemoveColumnsAndAddId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "filme");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "filme");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "filme");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "filme",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "filme",
                newName: "id");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "filme",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "filme",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "filme",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
