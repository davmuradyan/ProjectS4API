using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectS4API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations",
                column: "FinalId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Exams_FinalId",
                table: "Evaluations",
                column: "FinalId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
