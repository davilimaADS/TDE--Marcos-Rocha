using System;

namespace GestorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorTarefas gestor = new GestorTarefas(); 
            Menu menu = new Menu(gestor);  
            menu.ExibirMenu(); 
        }
    }
}
