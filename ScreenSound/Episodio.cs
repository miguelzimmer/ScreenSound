class Episodio
{
    public Episodio(string titulo, int duracao , int numero)
    {
        Titulo = titulo;
        Duracao = duracao;
        Numero = numero;
    }

    public int Duracao { get; set; }
    public int Numero { get; set; }
    public string Resumo => $"Episódio número:{Numero} com o título de:{Titulo} e com a duração:{Duracao} com o convidado {convidado }"
;   public string Titulo { get; }
    public Convidado convidado { get; set; }






    public void AdicionarConvidados(Convidado conv)
    {
        convidado = conv;
    }

}