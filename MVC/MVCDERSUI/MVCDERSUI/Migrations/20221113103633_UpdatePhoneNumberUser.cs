using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDERSUI.Migrations
{
    public partial class UpdatePhoneNumberUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "dbo",
                table: "UserMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "dbo",
                table: "UserMembers");
        }
    }
}
