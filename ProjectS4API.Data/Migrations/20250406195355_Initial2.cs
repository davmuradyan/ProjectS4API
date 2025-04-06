using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectS4API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_MidtermId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Ongoing_Evaluations_OngoingEvalId",
                table: "Evaluations");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations",
                column: "FinalId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_MidtermId",
                table: "Evaluations",
                column: "MidtermId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Ongoing_Evaluations_OngoingEvalId",
                table: "Evaluations",
                column: "OngoingEvalId",
                principalTable: "Ongoing_Evaluations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_MidtermId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Ongoing_Evaluations_OngoingEvalId",
                table: "Evaluations");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations",
                column: "FinalId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_MidtermId",
                table: "Evaluations",
                column: "MidtermId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Ongoing_Evaluations_OngoingEvalId",
                table: "Evaluations",
                column: "OngoingEvalId",
                principalTable: "Ongoing_Evaluations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
