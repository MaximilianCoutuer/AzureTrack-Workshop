using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RMotownFestival.DAL.Migrations
{
    public partial class RvSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleItems_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleItems_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ScheduleItems",
                columns: new[] { "Id", "ArtistId", "StageId", "Time" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 7, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, new DateTime(2021, 7, 1, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, new DateTime(2021, 7, 1, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 4, new DateTime(2021, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 1, new DateTime(2021, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItems_ArtistId",
                table: "ScheduleItems",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleItems_StageId",
                table: "ScheduleItems",
                column: "StageId");
        }
    }
}
