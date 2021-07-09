using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GloboTicket.Services.EventCatalog.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"),
                column: "Date",
                value: new DateTime(2022, 1, 5, 19, 54, 22, 246, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"),
                column: "Date",
                value: new DateTime(2022, 3, 5, 19, 54, 22, 247, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"),
                column: "Date",
                value: new DateTime(2022, 4, 5, 19, 54, 22, 247, DateTimeKind.Local).AddTicks(3524));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea317"),
                column: "Date",
                value: new DateTime(2021, 1, 11, 16, 22, 42, 250, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea318"),
                column: "Date",
                value: new DateTime(2021, 3, 11, 16, 22, 42, 252, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea319"),
                column: "Date",
                value: new DateTime(2021, 4, 11, 16, 22, 42, 252, DateTimeKind.Local).AddTicks(5753));
        }
    }
}
