class Playlist
{
    private List<Musica> musicaList = new List<Musica>();

    public Playlist(string nome, string nomeMusica)
    {
        NomeDaPlaylist = nome;
        Musica.Nome = nomeMusica;
    }

    public string NomeDaPlaylist { get; }
    public Musica Musica { get; }



    public void MenuExibirOpcaoPlaylist()
    {
        Console.WriteLine("1 - Para adicionar musicas a playlist");
        Console.WriteLine("2 - Para exibir a lista de musicas");
        Console.WriteLine("3 - Para sair do programa.");
        Console.Write("Selecione a opção que deseja:");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica) 
        {
            case 1: AdcionarMusica();
                break;
            case 2: ListarMusicas();
                break;
            case 3: Sair();
                break;
            default: Console.WriteLine("Voce digitou a opção errada!");
                break;

        }

    }


    public void ListarMusicas()
    {
        Console.WriteLine("Exibindo musicas da PlayList\n");

        foreach (var item in musicaList)
        {
            Console.WriteLine($"Nome: {item.Nome}");
        }
        Console.WriteLine("aperta qualquer tecla");
        Console.ReadKey();
    }

    public void Sair()
    {
        Console.WriteLine("VALEU AMIGO APERTE QUALQUER TECLA");
        Console.ReadKey();

    }
    public void AdcionarMusica()
    {
        Console.WriteLine("Criando sua Playlist\n");

        Console.Write("Escreva a musica que deseja adicionar:");
        string nomeTeste = Musica.Nome;
        nomeTeste = Console.ReadLine()!;

        //musicaList.Add(nomeTeste);

        MenuExibirOpcaoPlaylist();
    }

    public void ExibirPlayList() 
    {
        Console.WriteLine($"A playlist a ser exibida é {NomeDaPlaylist}\n");
        foreach (var item in musicaList)
        {
            Console.WriteLine($"{item.Nome}");
        }
    }

}