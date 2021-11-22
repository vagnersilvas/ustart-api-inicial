using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UStart.Infrastructure.Migrations
{
    public partial class imovel_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "usuario_id",
                table: "imoveis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "cliente_id",
                table: "imoveis",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "cliente_id1",
                table: "imoveis",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_imoveis_cliente_id1",
                table: "imoveis",
                column: "cliente_id1");

            migrationBuilder.CreateIndex(
                name: "ix_imoveis_usuario_id",
                table: "imoveis",
                column: "usuario_id");

            migrationBuilder.AddForeignKey(
                name: "fk_imoveis_clientes_cliente_id1",
                table: "imoveis",
                column: "cliente_id1",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_imoveis_usuarios_usuario_id",
                table: "imoveis",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_imoveis_clientes_cliente_id1",
                table: "imoveis");

            migrationBuilder.DropForeignKey(
                name: "fk_imoveis_usuarios_usuario_id",
                table: "imoveis");

            migrationBuilder.DropIndex(
                name: "ix_imoveis_cliente_id1",
                table: "imoveis");

            migrationBuilder.DropIndex(
                name: "ix_imoveis_usuario_id",
                table: "imoveis");

            migrationBuilder.DropColumn(
                name: "cliente_id1",
                table: "imoveis");

            migrationBuilder.AlterColumn<Guid>(
                name: "usuario_id",
                table: "imoveis",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "cliente_id",
                table: "imoveis",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }
    }
}
