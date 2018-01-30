using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASCA.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.AlterColumn<int>(
                name: "LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanDetails_SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "SavingId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "LoanId",
                principalSchema: "ASCA",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Savings_SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "SavingId",
                principalSchema: "ASCA",
                principalTable: "Savings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Savings_SavingId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.DropIndex(
                name: "IX_LoanDetails_SavingId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.DropColumn(
                name: "SavingId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.AlterColumn<int>(
                name: "LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "LoanId",
                principalSchema: "ASCA",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
