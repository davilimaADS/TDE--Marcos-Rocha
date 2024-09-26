using System;
namespace GestorDeTarefas
{

public class GestorTarefas
{
    private List<Tarefa> tarefas;
    private int proximoId;

    public GestorTarefas()
    {
        tarefas = new List<Tarefa>();
        proximoId = 1;
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefa.Id = proximoId++; 
        tarefas.Add(tarefa); 
    }

    public void ListarTarefas()
    {
        if (tarefas.Count == 0) 
        {
            Console.WriteLine("Nenhuma tarefa encontrada.");
            return;
        }

        foreach (var tarefa in tarefas) 
        {
            Console.WriteLine(tarefa);
        }
    }

    public void RemoverTarefa(int id)
    {
        Tarefa tarefa = tarefas.Find(t => t.Id == id); 
        if (tarefa != null) 
        {
            tarefas.Remove(tarefa); 
            Console.WriteLine($"Tarefa {id} removida.");
        }
        else
        {
            Console.WriteLine($"Tarefa {id} não encontrada."); 
        }
    }
}


}