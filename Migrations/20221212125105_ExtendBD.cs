using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToF.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class ExtendBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "first_trait",
                table: "simulacra",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "first_upgrade_materia;",
                table: "simulacra",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "second_trait",
                table: "simulacra",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "second_upgrade_materia;",
                table: "simulacra",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "favorite_gift",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    giftname = table.Column<string>(name: "gift_name", type: "text", nullable: false),
                    simulacraid = table.Column<Guid>(name: "simulacra_id", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_favorite_gift", x => x.id);
                    table.ForeignKey(
                        name: "simulacra_id",
                        column: x => x.simulacraid,
                        principalTable: "simulacra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_favorite_gift_id",
                table: "favorite_gift",
                column: "simulacra_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "simulacra_id",
                table: "ability");

            migrationBuilder.DropTable(
                name: "favorite_gift");

            migrationBuilder.DropColumn(
                name: "first_trait",
                table: "simulacra");

            migrationBuilder.DropColumn(
                name: "first_upgrade_materia;",
                table: "simulacra");

            migrationBuilder.DropColumn(
                name: "second_trait",
                table: "simulacra");

            migrationBuilder.DropColumn(
                name: "second_upgrade_materia;",
                table: "simulacra");
        }
    }
}
