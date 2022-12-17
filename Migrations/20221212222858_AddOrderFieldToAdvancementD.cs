using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToF.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderFieldToAdvancementD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "advancement",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "advancement");
        }
    }
}
