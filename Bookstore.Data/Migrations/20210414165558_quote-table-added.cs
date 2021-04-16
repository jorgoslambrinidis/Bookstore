using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class quotetableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tags = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "c2b93fd7-da45-43f1-938a-987caf06e9b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "5612ddd0-26b3-4b78-8334-fb5a072c1ffa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "3b57653b-c722-47e2-a883-df5b5cda1347");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIbTba0o7KaLI98UAbuzNlWf0/OqJkXLIpZcOrTUOwc6z1J/gAMNW1f2SIqmZ8VdGg==");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 289, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 290, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 55, 57, 295, DateTimeKind.Local).AddTicks(7659));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "ConcurrencyStamp",
                value: "89b2fbef-3107-40c2-b02d-c9e47ac67d64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e74",
                column: "ConcurrencyStamp",
                value: "cc9ad946-a62b-4955-a8f0-8c557574c3a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                column: "ConcurrencyStamp",
                value: "5ce7e16b-8490-425f-8d68-923de1b53530");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMKdxO96wquDjnZ5xlsisNutKnwEmua5GWGQ26S6MQaEUW+nivgOLUbhX0+vSJSciw==");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBirth",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 781, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2021, 4, 14, 18, 26, 0, 783, DateTimeKind.Local).AddTicks(4681));
        }
    }
}
