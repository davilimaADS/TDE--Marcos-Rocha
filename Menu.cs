using System;
namespace GestorDeTarefas
{
    public class Menu
    {
        private GestorTarefas gestor;

        public Menu(GestorTarefas gestor)
        {
            this.gestor = gestor;
        }

        public void ExibirMenu()
        {
            string opcao;

            do
            {
                // Exibe o menu
                Console.WriteLine("\n=== Gestor de Tarefas ===");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Adicionar tarefa com prazo");
                Console.WriteLine("3. Listar tarefas");
                Console.WriteLine("4. Remover tarefa");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    AdicionarTarefa();
                }
                else if (opcao == "2")
                {
                    AdicionarTarefaComPrazo();
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("\nLista de Tarefas:");
                    gestor.ListarTarefas();
                }
                else if (opcao == "4")
                {
                    RemoverTarefa();
                }
                else if (opcao == "0")
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

            } while (opcao != "0");
        }

        private void AdicionarTarefa()
        {
            Console.Write("Título da tarefa: ");
            string titulo = Console.ReadLine();
            Console.Write("Descrição da tarefa: ");
            string descricao = Console.ReadLine();

            Tarefa tarefa = new Tarefa(0, titulo, descricao);
            gestor.AdicionarTarefa(tarefa);

            Console.WriteLine("Tarefa adicionada!");
        }

        private void AdicionarTarefaComPrazo()
        {
            Console.Write("Título da tarefa: ");
            string titulo = Console.ReadLine();
            Console.Write("Descrição da tarefa: ");
            string descricao = Console.ReadLine();
            Console.Write("Prazo da tarefa (AAAA-MM-DD): ");
            DateTime prazo;
            while (!DateTime.TryParse(Console.ReadLine(), out prazo))
            {
                Console.Write("Data inválida. Por favor, insira novamente (AAAA-MM-DD): ");
            }

            TarefaPrazo tarefa = new TarefaPrazo(0, titulo, descricao, prazo);
            gestor.AdicionarTarefa(tarefa);

            Console.WriteLine("Tarefa com prazo adicionada!");
        }
        private void RemoverTarefa()
        {
            Console.Write("ID da tarefa a remover: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("ID inválido. Por favor, insira um número válido: ");
            }
            gestor.RemoverTarefa(id);
        }
    }
}