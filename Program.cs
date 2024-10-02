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
        Console.Write($"Tarefa: {Nome}\nStatus: {status}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Tarefa> tarefas = new List<Tarefa>();
        int opcao;


        do
        {   
            Console.WriteLine("=".PadRight(24));
            Console.WriteLine("GERENCIAMENTO DE TAREFAS");
            Console.WriteLine("=".PadRight(24));


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
                case '1':
                    
                    break;
            

                case '2':
                    foreach(var tarefa in tarefas)
                    {
                        tarefa.Exibir();
                    }
                    break;

                case '3':

                    break;


                case '4':

                    break;


                default:
                    Console.Write("Erro desconhecido!");
                    break;
            }
        }
        while(opcao != 0);
        Console.Write("Programa encerrado!");
    }
}
