Album albumDoQueen = new Album("A night at the opera");
Banda queen = new Banda("Queen");
Genero rock = new Genero("Rock");
Podcast podcast = new Podcast("Miguel", "FalaDevMiguel - Não é fetiçaria é tecnologia!");
Episodio episodio1 = new Episodio("Minha História",15000,1);
Episodio episodio2 = new Episodio("Não é feitiçaria é Tecnologia!",16000,2);
Convidado convidado1 = new Convidado("João");
Convidado convidado2 = new Convidado("Maria");

podcast.AdicionarEpisodio(episodio1);
episodio1.AdicionarConvidados(convidado1);
podcast.AdicionarEpisodio(episodio2);
episodio2.AdicionarConvidados(convidado2);
podcast.ExibirDetalhes();


Musica musica1 = new Musica(queen, "Love of my life", rock)
{
    Duracao = 213,
    Disponivel = true,
};
Musica musica2 = new Musica(queen, "Bohemian Rhapsody", rock)
{
    Duracao = 354,
    Disponivel = false,
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);




