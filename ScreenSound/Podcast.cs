class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    private readonly List<Episodio> episodiolist = new List<Episodio>();
    public string Host {  get; }
    public string Nome { get; }
    public int TotalEpisodios => episodiolist.Count;

    

    public void AdicionarEpisodio(Episodio ep)
    {
        episodiolist.Add(ep);
        Console.WriteLine("Um novo episodio foi adicionado!");
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Segue a lista de episódios meus amigos\n");
        foreach (Episodio item in episodiolist)
        {
            Console.WriteLine(item.Resumo);

        }
        Console.WriteLine("\n");
        Console.WriteLine($"Temos o total de episódios que é:{TotalEpisodios}");

    }
}