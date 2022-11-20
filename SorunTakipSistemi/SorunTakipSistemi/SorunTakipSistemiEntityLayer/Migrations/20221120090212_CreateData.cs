using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SorunTakipSistemiEntityLayer.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ProblemTrackings",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriorityStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationOpener = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transacter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemTrackings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserMemberRoles",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleCode = table.Column<int>(type: "int", nullable: false),
                    RoleNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMemberRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserMembers",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameSurname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<decimal>(type: "decimal(20,0)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserMemberRoleID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserMemberRoleID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMembers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserMembers_UserMemberRoles_UserMemberRoleID1",
                        column: x => x.UserMemberRoleID1,
                        principalSchema: "dbo",
                        principalTable: "UserMemberRoles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProblemTrackingComments",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProblemTrackingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserMemberID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemTrackingCommentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemTrackingComments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProblemTrackingComments_ProblemTrackingComments_ProblemTrackingCommentID",
                        column: x => x.ProblemTrackingCommentID,
                        principalSchema: "dbo",
                        principalTable: "ProblemTrackingComments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ProblemTrackingComments_ProblemTrackings_ProblemTrackingID",
                        column: x => x.ProblemTrackingID,
                        principalSchema: "dbo",
                        principalTable: "ProblemTrackings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProblemTrackingComments_UserMembers_UserMemberID",
                        column: x => x.UserMemberID,
                        principalSchema: "dbo",
                        principalTable: "UserMembers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTrackingComments_ProblemTrackingCommentID",
                schema: "dbo",
                table: "ProblemTrackingComments",
                column: "ProblemTrackingCommentID");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTrackingComments_ProblemTrackingID",
                schema: "dbo",
                table: "ProblemTrackingComments",
                column: "ProblemTrackingID");

            migrationBuilder.CreateIndex(
                name: "IX_ProblemTrackingComments_UserMemberID",
                schema: "dbo",
                table: "ProblemTrackingComments",
                column: "UserMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMembers_UserMemberRoleID1",
                schema: "dbo",
                table: "UserMembers",
                column: "UserMemberRoleID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemTrackingComments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProblemTrackings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserMembers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserMemberRoles",
                schema: "dbo");
        }
    }
}
