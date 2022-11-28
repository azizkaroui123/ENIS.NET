using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENISNC.Migrations
{
    /// <inheritdoc />
    public partial class vf22222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemandePFE_users_UserId",
                table: "DemandePFE");

            migrationBuilder.DropForeignKey(
                name: "FK_PaperUser_Paper_papersId",
                table: "PaperUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PaperUser_users_usersUserId",
                table: "PaperUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Departement_DepartementId",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_users_Section_sectionId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paper",
                table: "Paper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departement",
                table: "Departement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DemandePFE",
                table: "DemandePFE");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "sections");

            migrationBuilder.RenameTable(
                name: "Paper",
                newName: "papers");

            migrationBuilder.RenameTable(
                name: "Departement",
                newName: "departements");

            migrationBuilder.RenameTable(
                name: "DemandePFE",
                newName: "demandes");

            migrationBuilder.RenameColumn(
                name: "papersId",
                table: "PaperUser",
                newName: "paperspaperId");

            migrationBuilder.RenameColumn(
                name: "sectionId",
                table: "User",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_users_sectionId",
                table: "User",
                newName: "IX_User_SectionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sections",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Section_DepartementId",
                table: "sections",
                newName: "IX_sections_DepartementId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "papers",
                newName: "paperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "departements",
                newName: "DepartementId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandePFE_UserId",
                table: "demandes",
                newName: "IX_demandes_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "sectionName",
                table: "sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "schoolYear",
                table: "sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "sections",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "demanded_at",
                table: "papers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "approved_at",
                table: "papers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "papers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Staus",
                table: "papers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "spacialitée",
                table: "departements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "demandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "demanded_at",
                table: "demandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "demandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "approved_at",
                table: "demandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "demandes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sections",
                table: "sections",
                column: "SectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_papers",
                table: "papers",
                column: "paperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departements",
                table: "departements",
                column: "DepartementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_demandes",
                table: "demandes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_demandes_User_UserId",
                table: "demandes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaperUser_User_usersUserId",
                table: "PaperUser",
                column: "usersUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaperUser_papers_paperspaperId",
                table: "PaperUser",
                column: "paperspaperId",
                principalTable: "papers",
                principalColumn: "paperId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sections_departements_DepartementId",
                table: "sections",
                column: "DepartementId",
                principalTable: "departements",
                principalColumn: "DepartementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_sections_SectionId",
                table: "User",
                column: "SectionId",
                principalTable: "sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demandes_User_UserId",
                table: "demandes");

            migrationBuilder.DropForeignKey(
                name: "FK_PaperUser_User_usersUserId",
                table: "PaperUser");

            migrationBuilder.DropForeignKey(
                name: "FK_PaperUser_papers_paperspaperId",
                table: "PaperUser");

            migrationBuilder.DropForeignKey(
                name: "FK_sections_departements_DepartementId",
                table: "sections");

            migrationBuilder.DropForeignKey(
                name: "FK_User_sections_SectionId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sections",
                table: "sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_papers",
                table: "papers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departements",
                table: "departements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_demandes",
                table: "demandes");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "sections",
                newName: "Section");

            migrationBuilder.RenameTable(
                name: "papers",
                newName: "Paper");

            migrationBuilder.RenameTable(
                name: "departements",
                newName: "Departement");

            migrationBuilder.RenameTable(
                name: "demandes",
                newName: "DemandePFE");

            migrationBuilder.RenameColumn(
                name: "paperspaperId",
                table: "PaperUser",
                newName: "papersId");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "users",
                newName: "sectionId");

            migrationBuilder.RenameIndex(
                name: "IX_User_SectionId",
                table: "users",
                newName: "IX_users_sectionId");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Section",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_sections_DepartementId",
                table: "Section",
                newName: "IX_Section_DepartementId");

            migrationBuilder.RenameColumn(
                name: "paperId",
                table: "Paper",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DepartementId",
                table: "Departement",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_demandes_UserId",
                table: "DemandePFE",
                newName: "IX_DemandePFE_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sectionName",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "schoolYear",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Section",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "demanded_at",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "approved_at",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Staus",
                table: "Paper",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "spacialitée",
                table: "Departement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "DemandePFE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "demanded_at",
                table: "DemandePFE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "date",
                table: "DemandePFE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "approved_at",
                table: "DemandePFE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "DemandePFE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paper",
                table: "Paper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departement",
                table: "Departement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemandePFE",
                table: "DemandePFE",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DemandePFE_users_UserId",
                table: "DemandePFE",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaperUser_Paper_papersId",
                table: "PaperUser",
                column: "papersId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaperUser_users_usersUserId",
                table: "PaperUser",
                column: "usersUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Departement_DepartementId",
                table: "Section",
                column: "DepartementId",
                principalTable: "Departement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_Section_sectionId",
                table: "users",
                column: "sectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
