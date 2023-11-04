namespace Principios_SOLID.SRP.Violacao;

public class Loja
{
    public Loja(int id, string nome, string cep)
    {
        this.Id = id;
        this.Nome = nome;
        this.Endereco = GetEndereco(cep);
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public Endereco Endereco { get; set; }

    public bool CEPValid(string cep)
    {
        return cep.Length != 8;
    }

    public Endereco GetEndereco(string cep)
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
