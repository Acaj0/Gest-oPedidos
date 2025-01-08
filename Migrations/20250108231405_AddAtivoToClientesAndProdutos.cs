using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoPedidos.Migrations
{
    public partial class AddAtivoToClientesAndProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_clientes_ClienteId",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_produtos_ProdutoId",
                table: "pedidos");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "produtos",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "produtos",
                newName: "produtoid");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "pedidos",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "pedidos",
                newName: "produtoid");

            migrationBuilder.RenameColumn(
                name: "DataPedido",
                table: "pedidos",
                newName: "datapedido");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "pedidos",
                newName: "clienteid");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "pedidos",
                newName: "pedidoid");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_ProdutoId",
                table: "pedidos",
                newName: "IX_pedidos_produtoid");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_ClienteId",
                table: "pedidos",
                newName: "IX_pedidos_clienteid");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "clientes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clientes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "clientes",
                newName: "clienteid");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "produtos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "clientes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_clientes_clienteid",
                table: "pedidos",
                column: "clienteid",
                principalTable: "clientes",
                principalColumn: "clienteid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_produtos_produtoid",
                table: "pedidos",
                column: "produtoid",
                principalTable: "produtos",
                principalColumn: "produtoid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_clientes_clienteid",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_produtos_produtoid",
                table: "pedidos");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "clientes");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "produtoid",
                table: "produtos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "pedidos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "produtoid",
                table: "pedidos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "datapedido",
                table: "pedidos",
                newName: "DataPedido");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "pedidoid",
                table: "pedidos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_produtoid",
                table: "pedidos",
                newName: "IX_pedidos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_clienteid",
                table: "pedidos",
                newName: "IX_pedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "clientes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "clientes",
                newName: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_clientes_ClienteId",
                table: "pedidos",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_produtos_ProdutoId",
                table: "pedidos",
                column: "ProdutoId",
                principalTable: "produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
