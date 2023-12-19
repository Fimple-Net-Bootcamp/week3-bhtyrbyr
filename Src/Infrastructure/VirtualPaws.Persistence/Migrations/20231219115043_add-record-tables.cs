using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace VirtualPaws.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addrecordtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActivityId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityRecords_Activitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityRecords_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityRecords_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedRecords_PetFoods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "PetFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedRecords_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedRecords_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnershipRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnershipRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnershipRecords_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnershipRecords_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainingId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    PetId = table.Column<int>(type: "integer", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingRecords_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingRecords_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingRecords_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_ActivityId",
                table: "ActivityRecords",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_OwnerId",
                table: "ActivityRecords",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityRecords_PetId",
                table: "ActivityRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedRecords_FoodId",
                table: "FeedRecords",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedRecords_OwnerId",
                table: "FeedRecords",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedRecords_PetId",
                table: "FeedRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnershipRecords_OwnerId",
                table: "OwnershipRecords",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnershipRecords_PetId",
                table: "OwnershipRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingRecords_OwnerId",
                table: "TrainingRecords",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingRecords_PetId",
                table: "TrainingRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingRecords_TrainingId",
                table: "TrainingRecords",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityRecords");

            migrationBuilder.DropTable(
                name: "FeedRecords");

            migrationBuilder.DropTable(
                name: "OwnershipRecords");

            migrationBuilder.DropTable(
                name: "TrainingRecords");
        }
    }
}
