using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bitirme_projesi.DataAccessLayer.Migrations
{
    public partial class add_latest_reviews_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LatestReviewss",
                columns: table => new
                {
                    LatestReviewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatestReviewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestReviewsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestReviewsAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestReviewsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestReviewsTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestReviewss", x => x.LatestReviewsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LatestReviewss");
        }
    }
}
