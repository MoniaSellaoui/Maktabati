using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maktabati.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titre = table.Column<string>(type: "TEXT", nullable: false),
                    Auteur = table.Column<string>(type: "TEXT", nullable: false),
                    Isbn = table.Column<string>(type: "TEXT", nullable: false),
                    Statut = table.Column<string>(type: "TEXT", nullable: false),
                    Categorie = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    MotDePasse = table.Column<string>(type: "TEXT", nullable: false),
                    TypeUtilisateur = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    AbonnementActif = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emprunts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateEmprunt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateRetourPrevue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateRetourEffective = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LivreId = table.Column<int>(type: "INTEGER", nullable: false),
                    MembreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprunts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprunts_Livres_LivreId",
                        column: x => x.LivreId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emprunts_Utilisateurs_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Contenu = table.Column<string>(type: "TEXT", nullable: false),
                    DateEnvoi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MembreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Utilisateurs_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateReservation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Statut = table.Column<string>(type: "TEXT", nullable: false),
                    LivreId = table.Column<int>(type: "INTEGER", nullable: false),
                    MembreId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Livres_LivreId",
                        column: x => x.LivreId,
                        principalTable: "Livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Utilisateurs_MembreId",
                        column: x => x.MembreId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Penalites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Montant = table.Column<float>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EstPayee = table.Column<bool>(type: "INTEGER", nullable: false),
                    EmpruntId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penalites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Penalites_Emprunts_EmpruntId",
                        column: x => x.EmpruntId,
                        principalTable: "Emprunts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_LivreId",
                table: "Emprunts",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprunts_MembreId",
                table: "Emprunts",
                column: "MembreId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_MembreId",
                table: "Notifications",
                column: "MembreId");

            migrationBuilder.CreateIndex(
                name: "IX_Penalites_EmpruntId",
                table: "Penalites",
                column: "EmpruntId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LivreId",
                table: "Reservations",
                column: "LivreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MembreId",
                table: "Reservations",
                column: "MembreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Penalites");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Emprunts");

            migrationBuilder.DropTable(
                name: "Livres");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}
