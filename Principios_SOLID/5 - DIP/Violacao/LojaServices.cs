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

// A classe LojaServices está violando o Princípio da Inversão de Dependência (DIP) do SOLID.
// Ela está fortemente acoplada a classes concretas, CEPServices e LojaRepository, o que torna
// a manutenção e extensão do código mais difícil.