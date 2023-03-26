using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdLogicLib.Storage.Migrations
{
    /// <inheritdoc />
    public partial class OrdersLogicDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.IdOrder);
                });

            migrationBuilder.CreateTable(
                name: "Tranches",
                columns: table => new
                {
                    IdTranche = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrancheDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Residual = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranches", x => x.IdTranche);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserOrdersIdGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Orders_UserOrdersIdGuid",
                        column: x => x.UserOrdersIdGuid,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    IdOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTranche = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => new { x.IdOrder, x.IdTranche });
                    table.ForeignKey(
                        name: "FK_Payments_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Tranches_IdTranche",
                        column: x => x.IdTranche,
                        principalTable: "Tranches",
                        principalColumn: "IdTranche",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_IdTranche",
                table: "Payments",
                column: "IdTranche");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserOrdersIdGuid",
                table: "Users",
                column: "UserOrdersIdGuid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tranches");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
