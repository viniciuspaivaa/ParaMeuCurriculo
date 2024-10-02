using System.Diagnostics;

class Tarefa
{
    public string Nome {get; set;}
    public bool Concluida {get; set;}


    public Tarefa(string nome)
    {
        Nome = nome;
        Concluida = false;
    }


    public void Exibir()
    {
        // if(Concluida)
        // {
        //     Console.Write("Concluída");
        // }
        // else
        // {
        //     Console.Write("Não concluída");
        // }
        string status = Concluida ? "Concluída" : "Não concluída";
        Console.WriteLine($"Tarefa: {Nome}\nStatus: {status}\n");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Tarefa> tarefas = new List<Tarefa>();
        int opcao;
        int nmrTarefa;


        do
        {   
            Console.WriteLine("=".PadLeft(24, '='));
            Console.WriteLine("GERENCIAMENTO DE TAREFAS");
            Console.WriteLine("=".PadLeft(24, '='));


            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar como concluída");
            Console.WriteLine("4. Remover tarefa");
            Console.WriteLine("0. Sair");
            Console.Write("Digite o que deseja: ");


            while(!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 4)
            {
                Console.Write("Número inválido! Tente novamente: ");
            }
            
            
            switch(opcao)
            {
                case 1:
                    Console.Write("Digite o nome da tarefa: ");
                    string nomeTarefa = Console.ReadLine();
                    tarefas.Add(new Tarefa(nomeTarefa));
                    Console.WriteLine("Tarefa adicionada!\n");
                    break;

                case 2:
                    foreach(var tarefa in tarefas)
                    {
                        tarefa.Exibir();
                    }
                    Console.WriteLine("\n");
                    break;

                case 3:
                    Console.Write("Digite a posição da tarefa: ");
                    while(!int.TryParse(Console.ReadLine(), out nmrTarefa) || nmrTarefa < 1 || nmrTarefa > tarefas.Count() + 1)
                    {
                        Console.Write("Não possui uma tarefa nesta posição! Tente novamente: ");
                    }
                    tarefas[nmrTarefa -1].Concluida = true;
                    Console.WriteLine("Tarefa marcada como concluída!\n");
                    break;

                case 4:
                    Console.Write("Digite a posição da tarefa: ");
                    while(!int.TryParse(Console.ReadLine(), out nmrTarefa) || nmrTarefa < 1 || nmrTarefa > tarefas.Count() + 1)
                    {
                        Console.Write("Não possui uma tarefa nesta posição! Tente novamente: ");
                    }
                    tarefas.RemoveAt(nmrTarefa - 1);
                    Console.WriteLine("Tarefa removida com sucesso!\n");
                    break;
            }
        }
        while(opcao != 0);
        Console.Write("Programa encerrado!");
    }
}
