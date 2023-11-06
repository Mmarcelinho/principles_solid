namespace Principios_SOLID.OCP.Solucao;

public abstract class GerenciarTarefa
{
    public abstract void ListarTarefas(Tarefa tarefa);

}

// A classe abstrata GerenciarTarefa representa a base para a implementação
// do Princípio OCP (Open-Closed Principle) do SOLID. Ela define um método
// abstrato ListarTarefas, que deve ser implementado por classes derivadas,
// permitindo a extensão sem modificação do código existente.