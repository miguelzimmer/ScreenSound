class Album
{
    private List<Musica> musicaList = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }

    public int DuracaoTotal => musicaList.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ListarMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de múicas do álbum {Nome}:\n");
        foreach (var musica in musicaList)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao}\n");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos");
        
    }
}