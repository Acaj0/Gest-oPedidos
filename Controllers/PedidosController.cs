using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestaoPedidos.Data;
using GestaoPedidos.Models;
using System.Threading.Tasks;
using System.Linq;
using System;
using GestãoPedidos.Models;

namespace GestaoPedidos.Controllers
{
    public class PedidosController : Controller
    {
        private readonly AppDbContext _context;

        
        public PedidosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var pedidos = await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Produto)
                .ToListAsync();
            return View(pedidos);
        }

        public IActionResult Create()
        {
            var clientes = _context.Clientes.ToList();
            var produtos = _context.Produtos.ToList();

            if (!clientes.Any())
            {
                return View("Error", new ErrorViewModel { RequestId = "Nenhum cliente encontrado." });
            }

            if (!produtos.Any())
            {
                return View("Error", new ErrorViewModel { RequestId = "Nenhum produto encontrado." });
            }

            ViewBag.Clientes = clientes;
            ViewBag.Produtos = produtos;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PedidoId,ClienteId,ProdutoId,DataPedido,Quantidade,ValorTotal")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                if (pedido.DataPedido == default)
                {
                    pedido.DataPedido = DateTime.Now;
                }

                var produto = await _context.Produtos
                    .Where(p => p.ProdutoId == pedido.ProdutoId)
                    .FirstOrDefaultAsync();

                if (produto == null)
                {
                    ModelState.AddModelError(string.Empty, "Produto não encontrado.");
                    return View(pedido);
                }

                pedido.ValorTotal = produto.Preco * pedido.Quantidade;

                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(pedido);
        }
    }
}
