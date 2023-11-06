namespace Principios_SOLID.SRP.Solucao;

public class Loja
{
    public Loja(int id, string nome)
    {
        this.Id = id;
        this.Nome = nome;
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public Endereco Endereco { get; set; }

    public override string ToString()
    {
        return $"{this.Id} - {this.Nome} | Endereço: {this.Endereco}";
    }

}


// Classe CEPServices que lida com métodos de validação e busca de endereços.
// Agora, a classe Loja está livre da responsabilidade de lidar com essas tarefas.
// Ela se concentra apenas em representar informações sobre a loja.
