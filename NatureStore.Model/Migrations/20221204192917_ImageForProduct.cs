using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureStore.Model.Migrations
{
    /// <inheritdoc />
    public partial class ImageForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Products",
                type: "varbinary",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");
        }
    }
}
