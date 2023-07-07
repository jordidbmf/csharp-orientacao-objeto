class Episodio
{
    //private List<string> convidados = new List<string>();
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

  
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

    //public void ExibirResumo()
    //{
    //    Console.WriteLine($"Episódio {Ordem} - {Titulo} - {Duracao} min");
    //    foreach (string convidado in convidados)
    //    {
    //        Console.WriteLine($"Convidado: {convidado}");
    //    }
    //}
}