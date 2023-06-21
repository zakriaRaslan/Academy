using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IncluedeAllHierarchy.Migrations
{
    /// <inheritdoc />
    public partial class AddScheduleEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Sections",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Sections",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Sections",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "Time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Sections",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "Time");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Schedules",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
