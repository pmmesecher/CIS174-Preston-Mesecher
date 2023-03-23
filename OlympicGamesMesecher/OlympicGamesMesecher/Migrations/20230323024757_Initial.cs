using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGamesMesecher.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "Curling/Indoor", "Curling/Indoor" },
                    { "Bobsleigh/Outdoor", "Bobsleigh/Outdoor" },
                    { "Diving/Indoor", "Diving/Indoor" },
                    { "RoadCycling/Outdoor", "RoadCycling/Outdoor" },
                    { "Archery/Indoor", "Archery/Indoor" },
                    { "Canoe Sprint/Outdoor", "Canoe Sprint/Outdoor" },
                    { "Breakdancing/Indoor", "Breakdancing/Indoor" },
                    { "Skateboarding/Outdoor", "Skateboarding/Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "Winter Olympics", "Winter Olympics" },
                    { "Summer Olympics", "Summer Olympics" },
                    { "Paralympics", "Paralympics" },
                    { "Youth Olympic Games", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "GameID", "LogoImage", "Name" },
                values: new object[,]
                {
                    { "Can", "Curling/Indoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_ca-flag.gif", "Canada" },
                    { "Fin", "Skateboarding/Outdoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_fi-flag.gif", "Finland" },
                    { "Rus", "Breakdancing/Indoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_rs-flag.gif", "Russia" },
                    { "Cyp", "Breakdancing/Indoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_cy-flag.gif", "Cyprus" },
                    { "Fra", "Breakdancing/Indoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_fr-flag.gif", "France" },
                    { "Zim", "Canoe Sprint/Outdoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_zi-flag.gif", "Zimbabwe" },
                    { "Pak", "Canoe Sprint/Outdoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_pk-flag.gif", "Pakistan" },
                    { "Aus", "Canoe Sprint/Outdoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_au-flag.gif", "Austria" },
                    { "Ukr", "Archery/Indoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_up-flag.gif", "Ukraine" },
                    { "Uru", "Archery/Indoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_uy-flag.gif", "Uruguay" },
                    { "Tha", "Archery/Indoor", "Paralympics", "https://www.worldometers.info/img/flags/small/tn_th-flag.gif", "Thailand" },
                    { "USA", "RoadCycling/Outdoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_us-flag.gif", "USA" },
                    { "Net", "RoadCycling/Outdoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_nl-flag.gif", "Netherlands" },
                    { "Bra", "RoadCycling/Outdoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_br-flag.gif", "Brazil" },
                    { "Mex", "Diving/Indoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_mx-flag.gif", "Mexico" },
                    { "Chi", "Diving/Indoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_ch-flag.gif", "China" },
                    { "Ger", "Diving/Indoor", "Summer Olympics", "https://www.worldometers.info/img/flags/small/tn_gm-flag.gif", "Germany" },
                    { "Jap", "Bobsleigh/Outdoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_ja-flag.gif", "Japan" },
                    { "Ita", "Bobsleigh/Outdoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_it-flag.gif", "Italy" },
                    { "Jam", "Bobsleigh/Outdoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_jm-flag.gif", "Jamaica" },
                    { "Gre", "Curling/Indoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_uk-flag.gif", "Great Britain" },
                    { "Swe", "Curling/Indoor", "Winter Olympics", "https://www.worldometers.info/img/flags/small/tn_sw-flag.gif", "Sweden" },
                    { "Slo", "Skateboarding/Outdoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_lo-flag.gif", "Slovakia" },
                    { "Por", "Skateboarding/Outdoor", "Youth Olympic Games", "https://www.worldometers.info/img/flags/small/tn_po-flag.gif", "Portugal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
