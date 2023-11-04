namespace Principios_SOLID.ISP.Violacao;

    public class PedidoCliente : IPedido
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
