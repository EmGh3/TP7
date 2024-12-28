using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP7.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientMovies_Clients_clientId",
                table: "ClientMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientMovies_Movies_movieId",
                table: "ClientMovies");


            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "ClientMovies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "ClientMovies",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientMovies_movieId",
                table: "ClientMovies",
                newName: "IX_ClientMovies_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientMovies_clientId",
                table: "ClientMovies",
                newName: "IX_ClientMovies_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMovies_Clients_ClientId",
                table: "ClientMovies",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMovies_Movies_MovieId",
                table: "ClientMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientMovies_Clients_ClientId",
                table: "ClientMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientMovies_Movies_MovieId",
                table: "ClientMovies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ClientMovies",
                newName: "movieId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientMovies",
                newName: "clientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientMovies_MovieId",
                table: "ClientMovies",
                newName: "IX_ClientMovies_movieId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientMovies_ClientId",
                table: "ClientMovies",
                newName: "IX_ClientMovies_clientId");

            migrationBuilder.CreateTable(
                name: "ClientMovie",
                columns: table => new
                {
                    ClientsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMovie", x => new { x.ClientsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ClientMovie_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientMovie_MoviesId",
                table: "ClientMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMovies_Clients_clientId",
                table: "ClientMovies",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientMovies_Movies_movieId",
                table: "ClientMovies",
                column: "movieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
