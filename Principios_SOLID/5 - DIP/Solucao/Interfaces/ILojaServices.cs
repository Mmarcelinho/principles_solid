namespace Principios_SOLID.DIP.Solucao.Interfaces;

public interface ILojaServices
{
    public Loja CriarLoja(Loja loja, string cep);


    public void AdicionarLoja(Loja loja);

}
