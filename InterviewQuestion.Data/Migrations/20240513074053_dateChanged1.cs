using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewQuestion.Data.Migrations
{
    /// <inheritdoc />
    public partial class dateChanged1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultipleChoiceQuestionId",
                table: "ApplicationPrograms");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MultipleChoiceQuestionId",
                table: "ApplicationPrograms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
