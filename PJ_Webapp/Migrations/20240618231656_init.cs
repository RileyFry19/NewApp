using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PJ_Webapp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resources",
                columns: table => new
                {
                    resourceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    type = table.Column<int>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    amount = table.Column<int>(type: "INTEGER", nullable: false),
                    category = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resources", x => x.resourceId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<Guid>(type: "TEXT", nullable: false),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    hashedPassword = table.Column<byte[]>(type: "BLOB", nullable: false),
                    salt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    isAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    resetPassword = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "soldiers",
                columns: table => new
                {
                    soldierId = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    playerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    soldierClass = table.Column<int>(type: "INTEGER", nullable: false),
                    level = table.Column<int>(type: "INTEGER", nullable: false),
                    currentHealth = table.Column<int>(type: "INTEGER", nullable: false),
                    maxHealth = table.Column<int>(type: "INTEGER", nullable: false),
                    mental = table.Column<int>(type: "INTEGER", nullable: false),
                    soldierRace = table.Column<int>(type: "INTEGER", nullable: false),
                    loyalty = table.Column<int>(type: "INTEGER", nullable: false),
                    characterSheetLink = table.Column<string>(type: "TEXT", nullable: false),
                    aim = table.Column<int>(type: "INTEGER", nullable: false),
                    toughness = table.Column<int>(type: "INTEGER", nullable: false),
                    will = table.Column<int>(type: "INTEGER", nullable: false),
                    agility = table.Column<int>(type: "INTEGER", nullable: false),
                    power = table.Column<int>(type: "INTEGER", nullable: false),
                    healthStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    availableSkillPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    availableTalentPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    roleAvailableForAssignment = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_soldiers", x => x.soldierId);
                    table.ForeignKey(
                        name: "FK_soldiers_users_playerId",
                        column: x => x.playerId,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    skillId = table.Column<Guid>(type: "TEXT", nullable: false),
                    soldierId = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<int>(type: "INTEGER", nullable: false),
                    level = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.skillId);
                    table.ForeignKey(
                        name: "FK_skills_soldiers_soldierId",
                        column: x => x.soldierId,
                        principalTable: "soldiers",
                        principalColumn: "soldierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_skills_soldierId",
                table: "skills",
                column: "soldierId");

            migrationBuilder.CreateIndex(
                name: "IX_soldiers_playerId",
                table: "soldiers",
                column: "playerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resources");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "soldiers");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
