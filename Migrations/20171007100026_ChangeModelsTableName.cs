using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace aspnetvue.Migrations
{
    public partial class ChangeModelsTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modes_Makes_MakeId",
                table: "Modes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modes",
                table: "Modes");

            migrationBuilder.RenameTable(
                name: "Modes",
                newName: "Models");

            migrationBuilder.RenameIndex(
                name: "IX_Modes_MakeId",
                table: "Models",
                newName: "IX_Models_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Modes");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeId",
                table: "Modes",
                newName: "IX_Modes_MakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modes",
                table: "Modes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modes_Makes_MakeId",
                table: "Modes",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
