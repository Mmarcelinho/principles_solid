using Principios_SOLID.ISP.Solucao.Interfaces;
namespace Principios_SOLID.ISP.Solucao;

    public class PedidoProduto : IPedidoProduto
    {
        public void Validar()
        {
             Console.WriteLine("Implementação Validar PedidoProduto");
        }
    }
