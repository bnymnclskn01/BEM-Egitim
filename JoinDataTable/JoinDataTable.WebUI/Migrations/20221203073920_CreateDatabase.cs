using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoinDataTable.WebUI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "About",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdfUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    seoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoCopyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PdfUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    seoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoCopyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoDesign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seoSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalSchema: "dbo",
                        principalTable: "ProductCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                schema: "dbo",
                table: "Product",
                column: "ProductCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "dbo");
        }
    }
}
