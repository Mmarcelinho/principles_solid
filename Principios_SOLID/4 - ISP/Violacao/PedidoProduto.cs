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

// A classe PedidoProduto implementa a interface IPedido,
// mas há uma violação do princípio ISP (Princípio da Segregação de Interfaces) do SOLID,
// pois um produto de um pedido não possui a funcionalidade de enviar email.