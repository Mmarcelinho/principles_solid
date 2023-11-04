using System.Collections;
using System.Text.Json;
namespace Principios_SOLID.SRP.Violacao;

public class Loja
{

    public Loja(int id, string nome, string endereco)
    {
        this.Id = id;
        this.Nome = nome;
        this.Endereco = GetEndereco(endereco);
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public Endereco Endereco { get; set; }

    public static bool CEPValid(string cep)
    {
        return cep.Length != 8;
    }

    public static Endereco GetEndereco(string cep)
    {
        if (!CEPValid(cep))
            Console.WriteLine("Cep inválido");

        var client = new HttpClient();

        var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

        var content = response.Content.ReadAsStringAsync().Result;

        var enderecoResult = JsonSerializer.Deserialize<Endereco>(content);

        return enderecoResult;
    }
}
