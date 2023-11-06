namespace Principios_SOLID.OCP.Violacao
{
    public class GerenciarTarefa
    {
    List<Tarefa> TarefasPendentes { get; set; }
    List<Tarefa> TarefasFazendo { get; set; }
    List<Tarefa> TarefasConcluida { get; set; }

    public void ListarTarefas(Tarefa tarefa)
    {
        if(tarefa.Status == Status.Pendente)
        {
            TarefasPendentes.Add(tarefa);
            TarefasPendentes.ForEach(i => Console.WriteLine(i));
        }

        if(tarefa.Status == Status.Fazendo)
        {
            TarefasFazendo.Add(tarefa);
            TarefasFazendo.ForEach(i => Console.WriteLine(i));
        }

         if(tarefa.Status == Status.Concluida)
        {
            TarefasConcluida.Add(tarefa);
            TarefasConcluida.ForEach(i => Console.WriteLine(i));
        }
    }


}

}

/*
   Esta classe está violando o princípio OCP (Open/Closed Principle) do SOLID,
   uma vez que possui várias condicionais para verificar o status da tarefa e realizar ações específicas
   com base nesse status. Isso torna a classe vulnerável a modificações sempre que um novo status de
   tarefa é adicionado.
*/