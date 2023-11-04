namespace Principios_SOLID.OCP.Violacao;

public class Tarefa
{
    public Tarefa(string titulo, Status status)
    {
        this.Id = Guid.NewGuid();
        this.Titulo = titulo;
        this.Data = DateTime.Now;
        this.Status = status;
    }
    public Guid Id { get; set; }

    public string Titulo { get; set; }

    public DateTime Data { get; set; }

    public Status Status { get; set; }
}
