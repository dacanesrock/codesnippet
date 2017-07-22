using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codesnippet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Snippets",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodeSnippet = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 140, nullable: true),
                    Language = table.Column<string>(maxLength: 60, nullable: false),
                    Title = table.Column<string>(maxLength: 140, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snippets", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Snippets");
        }
    }
}
