class Podcast
{
    //private List<Episodio> episodios = new List<Episodio>();
    private List<Episodio> episodios = new ();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int SomaEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(ep => ep.Ordem))
        {            
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nTotal de episódios: {SomaEpisodios}.");
    }
}