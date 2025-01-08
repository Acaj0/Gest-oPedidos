using System;

namespace GestaoPedidos.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}
