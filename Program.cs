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
        string status = Concluida ? "Concluída" : "Não concluída";
        // if(Concluida)
        // {
        //     Console.Write("Concluída");
        // }
        // else
        // {
        //     Console.Write("Não concluída");
        // }
        Console.Write($"Tarefa: {Nome}\nStatus: {status}");
    }
}