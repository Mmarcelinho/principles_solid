namespace Principios_SOLID.DIP.Solucao;

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


