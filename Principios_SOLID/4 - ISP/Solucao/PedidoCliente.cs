using Principios_SOLID.ISP.Solucao.Interfaces;
namespace Principios_SOLID.ISP.Solucao;

    public class PedidoCliente : IPedidoCliente
    {
         public void Validar()
         {
            Console.WriteLine("Implementação Validar PedidoCliente");
         }

        public void EnviarEmail()
        {
             Console.WriteLine("Implementação EnviarEmail PedidoCliente");
        }
    }
