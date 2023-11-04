namespace Principios_SOLID.DIP.Violacao;

    public class LojaRepository
    {
        public void AdicionarLoja(Loja loja)
        {
   
            if(loja != null)
            Console.WriteLine("Loja adicionada no banco de dados!");
        }
    }
