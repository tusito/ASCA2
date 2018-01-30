using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASCA.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanDetails_Savings_SavingId",
                schema: "ASCA",
                table: "LoanDetails");

            migrationBuilder.AlterColumn<int>(
                name: "SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Savings_SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "SavingId",
                principalSchema: "ASCA",
                principalTable: "Savings",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
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

            migrationBuilder.AlterColumn<int>(
                name: "SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Loans_LoanId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "LoanId",
                principalSchema: "ASCA",
                principalTable: "Loans",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanDetails_Savings_SavingId",
                schema: "ASCA",
                table: "LoanDetails",
                column: "SavingId",
                principalSchema: "ASCA",
                principalTable: "Savings",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
