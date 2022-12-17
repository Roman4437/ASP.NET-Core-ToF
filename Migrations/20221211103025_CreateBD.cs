using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToF.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "simulacra",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    weaponname = table.Column<string>(name: "weapon_name", type: "text", nullable: false),
                    avatar = table.Column<string>(type: "text", nullable: false),
                    weaponavatar = table.Column<string>(name: "weapon_avatar", type: "text", nullable: false),
                    rarity = table.Column<string>(type: "text", nullable: false),
                    resonance = table.Column<string>(type: "text", nullable: false),
                    element = table.Column<string>(type: "text", nullable: false),
                    shatterrate = table.Column<float>(name: "shatter_rate", type: "real", nullable: false),
                    shatterscore = table.Column<string>(name: "shatter_score", type: "text", nullable: false),
                    chargerate = table.Column<float>(name: "charge_rate", type: "real", nullable: false),
                    chargescore = table.Column<string>(name: "charge_score", type: "text", nullable: false),
                    secondstat = table.Column<string>(name: "second_stat", type: "text", nullable: false),
                    thirdstat = table.Column<string>(name: "third_stat", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_simulacra", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ability",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    pattern = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    simulacraid = table.Column<Guid>(name: "simulacra_id", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ability", x => x.id);
                    table.ForeignKey(
                        name: "simulacra_id",
                        column: x => x.simulacraid,
                        principalTable: "simulacra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "advancement",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    simulacraid = table.Column<Guid>(name: "simulacra_id", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_advancement", x => x.id);
                    table.ForeignKey(
                        name: "simulacra_id",
                        column: x => x.simulacraid,
                        principalTable: "simulacra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recomended_matrice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    required = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    simulacraid = table.Column<Guid>(name: "simulacra_id", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_recomended_matrice", x => x.id);
                    table.ForeignKey(
                        name: "simulacra_id",
                        column: x => x.simulacraid,
                        principalTable: "simulacra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_effect",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    simulacraid = table.Column<Guid>(name: "simulacra_id", type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_effect", x => x.id);
                    table.ForeignKey(
                        name: "simulacra_id",
                        column: x => x.simulacraid,
                        principalTable: "simulacra",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_ability_simulacra_id",
                table: "ability",
                column: "simulacra_id");

            migrationBuilder.CreateIndex(
                name: "ix_advancement_simulacra_id",
                table: "advancement",
                column: "simulacra_id");

            migrationBuilder.CreateIndex(
                name: "ix_recomended_matrice_simulacra_id",
                table: "recomended_matrice",
                column: "simulacra_id");

            migrationBuilder.CreateIndex(
                name: "ix_weapon_effect_simulacra_id",
                table: "weapon_effect",
                column: "simulacra_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ability");

            migrationBuilder.DropTable(
                name: "advancement");

            migrationBuilder.DropTable(
                name: "recomended_matrice");

            migrationBuilder.DropTable(
                name: "weapon_effect");

            migrationBuilder.DropTable(
                name: "simulacra");
        }
    }
}
