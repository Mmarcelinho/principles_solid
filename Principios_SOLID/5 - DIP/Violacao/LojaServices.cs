namespace Principios_SOLID.DIP.Violacao;

    public class LojaServices
    {
        public Loja CriarLoja(Loja loja, string cep)
        {
            var CEPServices = new CEPServices();
            loja.Endereco = CEPServices.GetEndereco(cep);
            return loja;
        }

        public void AdicionarLoja(Loja loja)
        {
            var repository = new LojaRepository();
            repository.AdicionarLoja(loja);
        }
    }
