using Principios_SOLID.DIP.Solucao.Interfaces;

namespace Principios_SOLID.DIP.Solucao;

    public class LojaRepository : ILojaRepository
    {
        public void AdicionarLoja(Loja loja)
        {
   
            if(loja != null)
            Console.WriteLine("Loja adicionada no banco de dados!");
        }
    }
