using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM.EndPoint.WebApi.Databases.SQL.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_new_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Id",
                schema: "Security",
                table: "UserTokens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "UserTokens",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<long>(
                name: "Id",
                schema: "Security",
                table: "UserRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<long>(
                name: "Id",
                schema: "Security",
                table: "UserLogins",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "UserLogins",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "UserClaims",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                schema: "Security",
                table: "RoleClaims",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Security",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "UserTokens");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Security",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Security",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "UserClaims");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "Security",
                table: "RoleClaims");
        }
    }
}
