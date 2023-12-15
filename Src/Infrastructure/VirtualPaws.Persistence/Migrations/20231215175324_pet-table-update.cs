using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualPaws.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class pettableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "IsAdopted",
                table: "Pets",
                newName: "IsOwned");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OwnershipDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Pets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "IsOwned",
                table: "Pets",
                newName: "IsAdopted");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OwnershipDate",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Pets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_OwnerId",
                table: "Pets",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
