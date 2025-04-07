using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectS4API.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribution_of_Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CM = table.Column<float>(type: "real", nullable: false),
                    TP = table.Column<float>(type: "real", nullable: false),
                    TPS = table.Column<float>(type: "real", nullable: false),
                    ECT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_of_Hours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isFinal = table.Column<bool>(type: "bit", nullable: false),
                    isGroupBased = table.Column<bool>(type: "bit", nullable: false),
                    Oral = table.Column<bool>(type: "bit", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CM = table.Column<float>(type: "real", nullable: false),
                    TD = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Methods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ongoing_Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isProject = table.Column<bool>(type: "bit", nullable: false),
                    isPresentation = table.Column<bool>(type: "bit", nullable: false),
                    Criteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oral = table.Column<bool>(type: "bit", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ongoing_Evaluations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prerequisites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prerequisite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prerequisites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Core = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Additional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Web = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OngoingEvalId = table.Column<int>(type: "int", nullable: false),
                    MidtermId = table.Column<int>(type: "int", nullable: false),
                    FinalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Exams_FinalId",
                        column: x => x.FinalId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluations_Exams_MidtermId",
                        column: x => x.MidtermId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evaluations_Ongoing_Evaluations_OngoingEvalId",
                        column: x => x.OngoingEvalId,
                        principalTable: "Ongoing_Evaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    DoHId = table.Column<int>(type: "int", nullable: false),
                    AcademicYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluationId = table.Column<int>(type: "int", nullable: false),
                    ToolsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourcesId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Distribution_of_Hours_DoHId",
                        column: x => x.DoHId,
                        principalTable: "Distribution_of_Hours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Evaluations_EvaluationId",
                        column: x => x.EvaluationId,
                        principalTable: "Evaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Professors_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course_Prerequisites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Prerequisite = table.Column<int>(type: "int", nullable: false),
                    PrerequisiteEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Prerequisites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Prerequisites_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Prerequisites_Prerequisites_PrerequisiteEntityId",
                        column: x => x.PrerequisiteEntityId,
                        principalTable: "Prerequisites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knowledge_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Methods_and_Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    MethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methods_and_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Methods_and_Tools_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Methods_and_Tools_Methods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Methods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreResources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalResources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Topics_Hours_HourId",
                        column: x => x.HourId,
                        principalTable: "Hours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Prerequisites_CourseId",
                table: "Course_Prerequisites",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Prerequisites_PrerequisiteEntityId",
                table: "Course_Prerequisites",
                column: "PrerequisiteEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DoHId",
                table: "Courses",
                column: "DoHId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EvaluationId",
                table: "Courses",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ProfessorId",
                table: "Courses",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ResourcesId",
                table: "Courses",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_FinalId",
                table: "Evaluations",
                column: "FinalId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_MidtermId",
                table: "Evaluations",
                column: "MidtermId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_OngoingEvalId",
                table: "Evaluations",
                column: "OngoingEvalId");

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_CourseId",
                table: "Knowledge",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Methods_and_Tools_CourseId",
                table: "Methods_and_Tools",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Methods_and_Tools_MethodId",
                table: "Methods_and_Tools",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseId",
                table: "Topics",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_HourId",
                table: "Topics",
                column: "HourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Prerequisites");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Methods_and_Tools");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Prerequisites");

            migrationBuilder.DropTable(
                name: "Methods");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "Distribution_of_Hours");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Ongoing_Evaluations");
        }
    }
}
