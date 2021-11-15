using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UStart.Infrastructure.Migrations
{
    public partial class imovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "imoveis",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    cliente_id = table.Column<Guid>(type: "uuid", nullable: false),
                    usuario_id = table.Column<Guid>(type: "uuid", nullable: true),
                    tipo_imovel = table.Column<string>(type: "text", nullable: true),
                    url_imagem = table.Column<string>(type: "text", nullable: true),
                    rua = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    complemento = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    estado_id = table.Column<string>(type: "text", nullable: true),
                    cidade_id = table.Column<string>(type: "text", nullable: true),
                    cidade_nome = table.Column<string>(type: "text", nullable: true),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    finalidade = table.Column<string>(type: "text", nullable: true),
                    situacao = table.Column<string>(type: "text", nullable: true),
                    area_contruida = table.Column<decimal>(type: "numeric", nullable: false),
                    area_total = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_venda = table.Column<decimal>(type: "numeric", nullable: false),
                    valor_aluguel = table.Column<decimal>(type: "numeric", nullable: false),
                    dormitorios = table.Column<decimal>(type: "numeric", nullable: false),
                    suite = table.Column<decimal>(type: "numeric", nullable: false),
                    vagas_garagem = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_imoveis", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imoveis");
        }
    }
}
