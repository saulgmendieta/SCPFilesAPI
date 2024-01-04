using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SCPFilesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initializing_Entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellCode1",
                table: "SCP",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContentionArea",
                columns: table => new
                {
                    CellCode = table.Column<string>(type: "text", nullable: false),
                    Floor = table.Column<int>(type: "integer", nullable: false),
                    Area = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentionArea", x => x.CellCode);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SCPId = table.Column<double>(type: "double precision", nullable: false),
                    IncidentType = table.Column<string>(type: "text", nullable: false),
                    AlarmDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Acknowledge = table.Column<int>(type: "integer", nullable: false),
                    PersonnelAcked = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentLog_SCP_SCPId",
                        column: x => x.SCPId,
                        principalTable: "SCP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Classification = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SCP_CellCode1",
                table: "SCP",
                column: "CellCode1");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentLog_SCPId",
                table: "IncidentLog",
                column: "SCPId");

            migrationBuilder.AddForeignKey(
                name: "FK_SCP_ContentionArea_CellCode1",
                table: "SCP",
                column: "CellCode1",
                principalTable: "ContentionArea",
                principalColumn: "CellCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SCP_ContentionArea_CellCode1",
                table: "SCP");

            migrationBuilder.DropTable(
                name: "ContentionArea");

            migrationBuilder.DropTable(
                name: "IncidentLog");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropIndex(
                name: "IX_SCP_CellCode1",
                table: "SCP");

            migrationBuilder.DropColumn(
                name: "CellCode1",
                table: "SCP");
        }
    }
}
