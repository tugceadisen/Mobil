using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobil1.Migrations
{
    /// <inheritdoc />
    public partial class migmobil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaturaBilgileri",
                columns: table => new
                {
                    FaturaBilgi_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KDV_Orani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fatura_Tipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaBilgileri", x => x.FaturaBilgi_Id);
                });

            migrationBuilder.CreateTable(
                name: "Faturalar",
                columns: table => new
                {
                    Fatura_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fatura_Numarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sirket_Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Toplam_Tutar = table.Column<float>(type: "real", nullable: false),
                    Onay_Durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaBilgi_Id = table.Column<int>(type: "int", nullable: false),
                    Fatura_BilgiFaturaBilgi_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.Fatura_Id);
                    table.ForeignKey(
                        name: "FK_Faturalar_FaturaBilgileri_Fatura_BilgiFaturaBilgi_Id",
                        column: x => x.Fatura_BilgiFaturaBilgi_Id,
                        principalTable: "FaturaBilgileri",
                        principalColumn: "FaturaBilgi_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faturalar_Fatura_BilgiFaturaBilgi_Id",
                table: "Faturalar",
                column: "Fatura_BilgiFaturaBilgi_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "FaturaBilgileri");
        }
    }
}
