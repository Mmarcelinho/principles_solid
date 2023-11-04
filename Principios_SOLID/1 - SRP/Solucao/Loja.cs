namespace Principios_SOLID.SRP.Solucao;

public class Loja
{

    public Loja(int id, string nome, Endereco endereco)
    {
        this.Id = id;
        this.Nome = nome;
        this.Endereco = endereco;
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public Endereco Endereco { get; set; }

     public override string ToString()
    {
        return $"{this.Id} - {this.Nome} | Endereço: {this.Endereco}";
    }

}


