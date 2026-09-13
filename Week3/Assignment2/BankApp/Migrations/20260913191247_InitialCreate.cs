using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountHolders",
                columns: table => new
                {
                    AccountHolderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountHolders", x => x.AccountHolderId);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AccountType = table.Column<string>(type: "TEXT", nullable: false),
                    Balance = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountId);
                });

            migrationBuilder.CreateTable(
                name: "AccountHolderAccounts",
                columns: table => new
                {
                    AccountHolderId = table.Column<int>(type: "INTEGER", nullable: false),
                    BankAccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountHolderAccounts", x => new { x.AccountHolderId, x.BankAccountId });
                    table.ForeignKey(
                        name: "FK_AccountHolderAccounts_AccountHolders_AccountHolderId",
                        column: x => x.AccountHolderId,
                        principalTable: "AccountHolders",
                        principalColumn: "AccountHolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountHolderAccounts_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "BankAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountHolderAccounts_BankAccountId",
                table: "AccountHolderAccounts",
                column: "BankAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountHolderAccounts");

            migrationBuilder.DropTable(
                name: "AccountHolders");

            migrationBuilder.DropTable(
                name: "BankAccounts");
        }
    }
}
