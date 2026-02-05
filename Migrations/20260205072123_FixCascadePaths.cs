using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QAWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadePaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Questions_QuestionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 4, 7, 21, 22, 614, DateTimeKind.Utc).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 7, 21, 22, 614, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 21, 22, 427, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 2, 5, 7, 21, 22, 614, DateTimeKind.Utc).AddTicks(2558), "$2a$11$sZrx/1SF0lIV/xzS3XJaHeWS42jkie1yat.1SkFlhc4dDrrQ.ql3G" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Questions_QuestionId",
                table: "Comments",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Questions_QuestionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 4, 7, 20, 17, 169, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 3, 7, 20, 17, 169, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 7, 20, 16, 988, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 2, 5, 7, 20, 17, 169, DateTimeKind.Utc).AddTicks(5178), "$2a$11$CE2l5POu7LicXNBA09YZ/uUeOl68cTK8Xflsc2twYP3OohDaa.4gW" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Questions_QuestionId",
                table: "Comments",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
