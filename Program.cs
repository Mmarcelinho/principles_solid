var tarefa1 = new Tarefa("Tarefa1", Status.Pendente);
var tarefa2 = new Tarefa("Tarefa2", Status.Fazendo);
var tarefa3 = new Tarefa("Tarefa3", Status.Concluida);

var tarefasPendente = new GerenciarTarefasPendente();
tarefasPendente.ListarTarefas(tarefa1);

var tarefasEmAndamento = new GerenciarTarefaEmAndamento();
tarefasEmAndamento.ListarTarefas(tarefa2);

var tarefasConcluidas = new GerenciarTarefasConcluidas();
tarefasConcluidas.ListarTarefas(tarefa3);
