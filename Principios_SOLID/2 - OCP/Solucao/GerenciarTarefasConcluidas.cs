namespace Principios_SOLID.OCP.Solucao;

public class GerenciarTarefasConcluidas : GerenciarTarefa
{
    List<Tarefa> TarefasConcluida { get; set; }

      public GerenciarTarefasConcluidas()
        {
            TarefasConcluida = new List<Tarefa>();
        }

    public override void ListarTarefas(Tarefa tarefa)
    {
        if (tarefa.Status == Status.Concluida)
        {
            TarefasConcluida.Add(tarefa);
            TarefasConcluida.ForEach(i => Console.WriteLine(i));
        }
    }
}
