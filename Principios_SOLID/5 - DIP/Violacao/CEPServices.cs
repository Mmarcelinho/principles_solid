namespace Principios_SOLID.DIP.Violacao;

public class CEPServices
{
    public bool CEPValid(string cep)
    {
        return cep.Length == 8;
    }

    public Endereco GetEndereco(string cep)
    {
        if(!CEPValid(cep))
        Console.WriteLine("Cep inválido");

        var client = new HttpClient();

        var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

        var content = response.Content.ReadAsStringAsync().Result;

        var enderecoResult = JsonSerializer.Deserialize<Endereco>(content);

        return enderecoResult;
    }
}
