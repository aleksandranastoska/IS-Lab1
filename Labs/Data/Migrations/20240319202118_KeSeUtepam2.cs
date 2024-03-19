using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs.Data.Migrations
{
    /// <inheritdoc />
    public partial class KeSeUtepam2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TheatreShows_TheatreShowId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Tickets");

            migrationBuilder.AlterColumn<Guid>(
                name: "TheatreShowId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TheatreShows_TheatreShowId",
                table: "Tickets",
                column: "TheatreShowId",
                principalTable: "TheatreShows",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TheatreShows_TheatreShowId",
                table: "Tickets");

            migrationBuilder.AlterColumn<Guid>(
                name: "TheatreShowId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ShowId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TheatreShows_TheatreShowId",
                table: "Tickets",
                column: "TheatreShowId",
                principalTable: "TheatreShows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
