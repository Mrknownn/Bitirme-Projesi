using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bitirme_projesi.DataAccessLayer.Migrations
{
    public partial class add_videopart_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoParts",
                columns: table => new
                {
                    videoPartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videoDataNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videoPartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videoAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoParts", x => x.videoPartID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoParts");
        }
    }
}
