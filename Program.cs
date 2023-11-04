using Principios_SOLID.SRP.Solucao;
using Principios_SOLID.OCP.Solucao;
/*
var endereco = CEPServices.GetEndereco("45400000");
var loja = new Loja(1, "loja", endereco);
Console.WriteLine(loja.ToString());
*/


var tarefa1 = new Tarefa("Tarefa1", Status.Pendente);
var tarefa2 = new Tarefa("Tarefa2", Status.Fazendo);
var tarefa3 = new Tarefa("Tarefa3", Status.Concluida);

var tarefasPendente = new GerenciarTarefasPendente();
tarefasPendente.ListarTarefas(tarefa1);

var tarefasEmAndamento = new GerenciarTarefaEmAndamento();
tarefasEmAndamento.ListarTarefas(tarefa2);

var tarefasConcluidas = new GerenciarTarefasConcluidas();
tarefasConcluidas.ListarTarefas(tarefa3);
