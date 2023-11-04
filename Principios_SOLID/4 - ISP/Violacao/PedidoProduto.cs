namespace Principios_SOLID.ISP.Violacao;

    public class PedidoProduto : IPedido
    {
        public void Validar()
         {
            Console.WriteLine("Implementação Validar PedidoProduto");
         }

        public void EnviarEmail()
        {
             Console.WriteLine("Implementação EnviarEmail PedidoProduto");
        }
    }
