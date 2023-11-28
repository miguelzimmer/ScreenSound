class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host {  get; }
    public string Nome { get; }
    public int TotalEpisodios { get; set; }

    private readonly List<Episodio> episodiolist;

    public void AdicionarEpisodio(Episodio ep)
    {
        episodiolist.Add(ep);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Olá seja bem vindo ao podcast {Nome} aqui quem fala é o {Host}\n");

    }
}