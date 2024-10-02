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
        string[] tarefas;
        int opcao;


        do
        {   
            Console.WriteLine();
            while(!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Número inválido! Tente novamente: ");
            }
            
        }
        while(opcao != 0);
    }
}
