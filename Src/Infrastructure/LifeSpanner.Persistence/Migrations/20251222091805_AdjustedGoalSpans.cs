using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeSpanner.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedGoalSpans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "GoalSpan");

            migrationBuilder.DropColumn(
                name: "SpanId",
                table: "GoalSpan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "GoalSpan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpanId",
                table: "GoalSpan",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
