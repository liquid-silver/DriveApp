using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DriveApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filename = table.Column<string>(nullable: true),
                    data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    roleId = table.Column<int>(nullable: false),
                    roleIdNavigationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_roleIdNavigationid",
                        column: x => x.roleIdNavigationid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    fio = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    driverLicense = table.Column<int>(nullable: false),
                    registrationDate = table.Column<DateTime>(nullable: false),
                    photoId = table.Column<int>(nullable: false),
                    photoIdNavigationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Drivers_Users_id",
                        column: x => x.id,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drivers_Images_photoIdNavigationid",
                        column: x => x.photoIdNavigationid,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Timetable",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    driverId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    startTime = table.Column<TimeSpan>(nullable: false),
                    finishTime = table.Column<TimeSpan>(nullable: false),
                    driverIdNavigationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetable", x => x.id);
                    table.ForeignKey(
                        name: "FK_Timetable_Drivers_driverIdNavigationid",
                        column: x => x.driverIdNavigationid,
                        principalTable: "Drivers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    driverId = table.Column<int>(nullable: false),
                    categoryId = table.Column<int>(nullable: false),
                    yearOfIssue = table.Column<int>(nullable: false),
                    seats = table.Column<int>(nullable: false),
                    photoId = table.Column<int>(nullable: false),
                    driverIdNavigationid = table.Column<int>(nullable: true),
                    categoryIdNavigationid = table.Column<int>(nullable: true),
                    photoIdNavigationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Categories_categoryIdNavigationid",
                        column: x => x.categoryIdNavigationid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Drivers_driverIdNavigationid",
                        column: x => x.driverIdNavigationid,
                        principalTable: "Drivers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Images_photoIdNavigationid",
                        column: x => x.photoIdNavigationid,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timetableId = table.Column<int>(nullable: false),
                    startTime = table.Column<TimeSpan>(nullable: false),
                    finishTime = table.Column<TimeSpan>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employment_Timetable_timetableId",
                        column: x => x.timetableId,
                        principalTable: "Timetable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleId = table.Column<int>(nullable: false),
                    priceInside = table.Column<double>(nullable: false),
                    priceOutside = table.Column<double>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    vehicleIdNavigationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Vehicles_vehicleIdNavigationid",
                        column: x => x.vehicleIdNavigationid,
                        principalTable: "Vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    loadCapacity = table.Column<double>(nullable: false),
                    capacity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Trucks_Vehicles_id",
                        column: x => x.id,
                        principalTable: "Vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_vehicleIdNavigationid",
                table: "Advertisements",
                column: "vehicleIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_photoIdNavigationid",
                table: "Drivers",
                column: "photoIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_timetableId",
                table: "Employment",
                column: "timetableId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetable_driverIdNavigationid",
                table: "Timetable",
                column: "driverIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleIdNavigationid",
                table: "Users",
                column: "roleIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_categoryIdNavigationid",
                table: "Vehicles",
                column: "categoryIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_driverIdNavigationid",
                table: "Vehicles",
                column: "driverIdNavigationid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_photoIdNavigationid",
                table: "Vehicles",
                column: "photoIdNavigationid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "Timetable");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
