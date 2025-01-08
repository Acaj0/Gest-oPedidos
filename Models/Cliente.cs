using System.Collections.Generic;

namespace GestaoPedidos.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; } = true; 

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
