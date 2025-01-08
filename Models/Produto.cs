using System.Collections.Generic;

namespace GestaoPedidos.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Ativo { get; set; } = true;
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
