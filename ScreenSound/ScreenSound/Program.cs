#region Testes Classe Musicas
//Musica musica1 = new Musica();
//musica1.Nome = "Roxane";
//musica1.Artista = "The Police";
//musica1.Duracao = 273;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.Disponivel);
//Console.WriteLine(musica1.DescricaoResumida);

//Musica musica2 = new Musica();
//musica2.Nome = "Vertigo";
//musica2.Artista = "U2"; 
//musica2.Duracao = 367;
//musica1.Disponivel = false;

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
#endregion

#region Testes Bandas
//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Genero rock = new Genero("Rock");

//Musica musica1 = new Musica(queen, "Love of my life", rock)
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody", rock)
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);
//rock.AdicionarBanda(queen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();
//rock.ExibirBandasDoGenero();

#endregion

#region Testes Podcast

Episodio episodio1 = new Episodio(2, "Técnicas de facilitação", 45);
episodio1.AdicionarConvidados("José");
episodio1.AdicionarConvidados("Maria");


Episodio episodio2 = new(1, "Técnicas de aprendizado", 60);
episodio2.AdicionarConvidados("Fernando");
episodio2.AdicionarConvidados("Marcela");
episodio2.AdicionarConvidados("Lucio");


Podcast podcast = new Podcast("Podcast especial", "Jordi");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();


#endregion