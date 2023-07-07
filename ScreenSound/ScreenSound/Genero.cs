class Genero
{
    private List<Banda> bandas = new List<Banda>();
    public Genero(string nomeDoGenero)
    {
        NomeDoGenero = nomeDoGenero;
    }

    public string NomeDoGenero { get; }

    public void AdicionarBanda(Banda banda)
    {
        bandas.Add(banda);
    }

    public void ExibirBandasDoGenero()
    {
        Console.WriteLine($"Lista de bandas do gênero {NomeDoGenero}: ");
        foreach(Banda banda in bandas)
        {
            Console.WriteLine($"Banda: {banda.Nome}");
        }
    }
}
