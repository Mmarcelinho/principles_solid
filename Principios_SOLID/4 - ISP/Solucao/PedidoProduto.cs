using Principios_SOLID.ISP.Solucao.Interfaces;
namespace Principios_SOLID.ISP.Solucao;

public class PedidoProduto : IPedidoProduto
{
    public void Validar()
    {
        Console.WriteLine("Implementação Validar PedidoProduto");
    }
}

// A classe PedidoProduto agora adota a abordagem de implementar a interface IPedidoProduto,
// substituindo a ideia de possuir interfaces específicas. Isso segue o princípio ISP (Princípio da
// Segregação de Interfaces) do SOLID, que incentiva interfaces mais genéricas em vez de muitas
// interfaces específicas para atender várias classes.