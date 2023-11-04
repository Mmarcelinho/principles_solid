namespace Principios_SOLID.OCP.Solucao;
public class GerenciarTarefaEmAndamento : GerenciarTarefa
{
    List<Tarefa> TarefasFazendo { get; set; }

      public GerenciarTarefaEmAndamento()
        {
            TarefasFazendo = new List<Tarefa>();
        }
    public override void ListarTarefas(Tarefa tarefa)
    {
        if (tarefa.Status == Status.Fazendo)
        {
            TarefasFazendo.Add(tarefa);
            TarefasFazendo.ForEach(i => Console.WriteLine(i));
        }
    }

}
