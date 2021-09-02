using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApi.Migrations
{
    public partial class SeedToDO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "IsComplete", "Name" },
                values: new object[] { 2343423423L, false, "just do it" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 2343423423L);
        }
    }
}
