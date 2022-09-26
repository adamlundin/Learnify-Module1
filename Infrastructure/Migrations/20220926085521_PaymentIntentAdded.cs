using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PaymentIntentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bdc840b-5b14-4ecf-93a8-5eb841ed1fee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8eb33006-f095-48ce-8d43-f825df6093c7");

            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "Baskets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Baskets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4d75d5f-2ce7-466b-ad83-ba1d29650531", "bda8a012-2ab9-4701-a1a4-d1fbbca606e4", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb77a283-96d7-405e-92df-4dda97fe799d", "fcda9f92-533b-4772-b2aa-29d882942543", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4d75d5f-2ce7-466b-ad83-ba1d29650531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb77a283-96d7-405e-92df-4dda97fe799d");

            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Baskets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bdc840b-5b14-4ecf-93a8-5eb841ed1fee", "a3b91367-612c-4c7a-bc31-5a36c70b750c", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8eb33006-f095-48ce-8d43-f825df6093c7", "191399d0-2455-4964-ab6f-a5f0d7bb8d52", "Instructor", "INSTRUCTOR" });
        }
    }
}
