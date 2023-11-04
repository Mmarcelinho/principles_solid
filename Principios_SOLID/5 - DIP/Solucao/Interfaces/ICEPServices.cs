namespace Principios_SOLID.DIP.Solucao.Interfaces;

public interface ICEPServices
{
    public bool CEPValid(string cep);

    public Endereco GetEndereco(string cep);

}
