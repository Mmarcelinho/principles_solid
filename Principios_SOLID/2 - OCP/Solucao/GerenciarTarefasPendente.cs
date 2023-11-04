namespace Principios_SOLID.OCP.Solucao;

public class GerenciarTarefasPendente : GerenciarTarefa
{
    List<Tarefa> TarefasPendentes { get; set; }

       public GerenciarTarefasPendente()
        {
            TarefasPendentes = new List<Tarefa>();
        }
    public override void ListarTarefas(Tarefa tarefa)
    {
        if (tarefa.Status == Status.Pendente)
        {
            TarefasPendentes.Add(tarefa);
            TarefasPendentes.ForEach(i => Console.WriteLine(i));
        }
    }
}
