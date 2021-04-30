using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Manager.Data.Migrations
{
    public partial class AddedLeaveDatapoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave_Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datecreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Leave_ALlocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberofDays = table.Column<int>(type: "int", nullable: false),
                    Datecreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_ALlocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leave_ALlocations_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leave_ALlocations_Leave_Types_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "Leave_Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leave_Historie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavetypeID = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateActtioned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    ApprovedbyID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_Historie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leave_Historie_AspNetUsers_ApprovedbyID",
                        column: x => x.ApprovedbyID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leave_Historie_AspNetUsers_RequestingEmployeeID",
                        column: x => x.RequestingEmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leave_Historie_Leave_Types_LeavetypeID",
                        column: x => x.LeavetypeID,
                        principalTable: "Leave_Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leave_ALlocations_EmployeeID",
                table: "Leave_ALlocations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_ALlocations_LeaveTypeID",
                table: "Leave_ALlocations",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_Historie_ApprovedbyID",
                table: "Leave_Historie",
                column: "ApprovedbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_Historie_LeavetypeID",
                table: "Leave_Historie",
                column: "LeavetypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_Historie_RequestingEmployeeID",
                table: "Leave_Historie",
                column: "RequestingEmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave_ALlocations");

            migrationBuilder.DropTable(
                name: "Leave_Historie");

            migrationBuilder.DropTable(
                name: "Leave_Types");
        }
    }
}
