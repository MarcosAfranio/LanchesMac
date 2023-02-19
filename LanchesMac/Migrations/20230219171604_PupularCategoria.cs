using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <hereditariedade />
    public partial class PupularCategoria : Migration
    {
        /// <hereditariedade />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
               "VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");
        }

        /// <hereditariedade />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELITE FROM Categorias");
        }
    }
}
