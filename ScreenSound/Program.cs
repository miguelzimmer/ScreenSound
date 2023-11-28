Album albumDoQueen = new Album("A night at the opera");
Banda queen = new Banda("Queen");
Genero rock = new Genero("Rock");
Podcast podcast = new Podcast("Miguel", "FalaDevMiguel - Não é fetiçaria é tecnologia! ");

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




