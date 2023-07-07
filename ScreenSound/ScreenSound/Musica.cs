class Musica
{
    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}."; //se trata só do get
//    {
//        get
//        {
//            return $"A música {Nome} pertence à banda {Artista}."
//;
//        }
//    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    //Desafio:
    //public void ExibirNomeEArtista()
    //{
    //    Console.WriteLine($"Nome: {Nome} - Artista: {Artista}");
    //}
}


