using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bitirme_projesi.DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryNewss",
                columns: table => new
                {
                    CategoryNewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryNewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryNewsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryNewsAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryNewsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryNewsTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryNewss", x => x.CategoryNewsID);
                });

            migrationBuilder.CreateTable(
                name: "EditorsPickss",
                columns: table => new
                {
                    EditorsPicksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorsPicksTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorsPicksDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorsPicksAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorsPicksImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorsPicksTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorsPickss", x => x.EditorsPicksID);
                });

            migrationBuilder.CreateTable(
                name: "LatestArticless",
                columns: table => new
                {
                    LatestArticlesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatestArticlesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestArticlesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestArticlesAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestArticlesImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestArticlesTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestArticless", x => x.LatestArticlesID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSenderSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSenderPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageSendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "MidParts",
                columns: table => new
                {
                    MidPartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidPartTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidPartDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidPartAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidPartImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidPartTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MidParts", x => x.MidPartID);
                });

            migrationBuilder.CreateTable(
                name: "MostVieweds",
                columns: table => new
                {
                    MostViewedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MostViewedTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MostViewedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MostViewedAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MostViewedImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MostViewedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MostVieweds", x => x.MostViewedID);
                });

            migrationBuilder.CreateTable(
                name: "Newss",
                columns: table => new
                {
                    NewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newss", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "PopulerNewss",
                columns: table => new
                {
                    PopulerNewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PopulerNewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopulerNewsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopulerNewsAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopulerNewsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PopulerNewsTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulerNewss", x => x.PopulerNewsID);
                });

            migrationBuilder.CreateTable(
                name: "RecentPosts",
                columns: table => new
                {
                    RecentPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecentPostTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecentPostDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecentPostAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecentPostImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecentPostTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentPosts", x => x.RecentPostID);
                });

            migrationBuilder.CreateTable(
                name: "TechandInnovations",
                columns: table => new
                {
                    TechandInnovationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechandInnovationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechandInnovationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechandInnovationAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechandInnovationImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechandInnovationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechandInnovations", x => x.TechandInnovationID);
                });

            migrationBuilder.CreateTable(
                name: "TopStoriess",
                columns: table => new
                {
                    TopStoriesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopStoriesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopStoriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopStoriesAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopStoriesImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopStoriesTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopStoriess", x => x.TopStoriesID);
                });

            migrationBuilder.CreateTable(
                name: "TrendingNows",
                columns: table => new
                {
                    TrendingNowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrendingNowTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrendingNowDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrendingNowAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrendingNowDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrendingNows", x => x.TrendingNowID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryNewss");

            migrationBuilder.DropTable(
                name: "EditorsPickss");

            migrationBuilder.DropTable(
                name: "LatestArticless");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "MidParts");

            migrationBuilder.DropTable(
                name: "MostVieweds");

            migrationBuilder.DropTable(
                name: "Newss");

            migrationBuilder.DropTable(
                name: "PopulerNewss");

            migrationBuilder.DropTable(
                name: "RecentPosts");

            migrationBuilder.DropTable(
                name: "TechandInnovations");

            migrationBuilder.DropTable(
                name: "TopStoriess");

            migrationBuilder.DropTable(
                name: "TrendingNows");
        }
    }
}
