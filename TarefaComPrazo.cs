using System;
namespace GestorDeTarefas
{
    public class TarefaPrazo : Tarefa{
        public DateTime Prazo { get; set; }

    public TarefaPrazo(int id, string titulo, string descricao, DateTime prazo)
    : base(id, titulo, descricao)
        {
            Prazo = prazo;
        }
    

    public override string ToString()
        {
            return base.ToString() +$", Prazo:{Prazo.ToShortDateString()}";
        }


}}