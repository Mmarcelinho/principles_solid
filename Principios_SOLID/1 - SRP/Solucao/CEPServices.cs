namespace Principios_SOLID.SRP.Solucao;

public static class CEPServices
{
    public static bool CEPValid(string cep)
    {
        return cep.Length == 8;
    }

    public static Endereco GetEndereco(string cep)
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
