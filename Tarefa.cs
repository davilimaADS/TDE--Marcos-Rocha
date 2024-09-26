using System;

namespace GestorDeTarefas
{
    public class Tarefa{
        public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(int id, string titulo, string descricao) { 

        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;
    }
    
    public void concluido(){
        Concluida = true;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Título: {Titulo}, Descrição: {Descricao}, Concluída: {Concluida}";
    }
}

}