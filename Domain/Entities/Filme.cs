namespace Contract.Extraction.Api.Domain.Entities;

public class Filme
{
    public Filme(string titulo, string diretor, string elenco, string pais, int ano)
    {
        Titulo = titulo;
        Diretor = diretor;
        Elenco = elenco;
        Pais = pais;
        Ano = ano;
    }

    public int Id { get; init; }
    public string Titulo { get; set; }
    public string Diretor { get; set; }
    public string Elenco { get; set; }
    public string Pais { get; set; }
    public int Ano { get; set; }
}
    