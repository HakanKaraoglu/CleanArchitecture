using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    public partial class RequiredChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 8, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7051), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 7, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7035), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 2, 28, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7046), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 6, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7057), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 2, 28, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7041), null });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { null, new DateTime(2023, 4, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7002), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { null, null, new DateTime(2022, 10, 30, 15, 41, 39, 964, DateTimeKind.Local).AddTicks(7092) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf3f3002-7e53-441e-8b76-f6280be284aa"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe98f549-e790-4e9f-aa16-18c2292a2ee9"),
                columns: new[] { "CreatedBy", "LastModifiedBy" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 8, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4600), "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 7, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4582), "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 2, 28, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4594), "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 6, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4607), "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 2, 28, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4589), "" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                columns: new[] { "CreatedBy", "Date", "LastModifiedBy" },
                values: new object[] { "", new DateTime(2023, 4, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4551), "" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                columns: new[] { "CreatedBy", "LastModifiedBy", "OrderPlaced" },
                values: new object[] { "", "", new DateTime(2022, 10, 30, 13, 12, 25, 189, DateTimeKind.Local).AddTicks(4642) });
        }
    }
}
