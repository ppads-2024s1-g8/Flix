﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Book
{
    public Book(string titulo, string autor, string editora, string pais, int anoLancamento)
    {
        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        Pais = pais;
        AnoLancamento = anoLancamento;
    }
    [Key]
    public int Id { get; init; }
    public string Titulo { get; set; } = default!;
    public string Autor { get; set; } = default!;
    public string Editora { get; set; } = default!;
    public string Pais { get; set; } = default!;
    public int AnoLancamento { get; set; } = default!;

}
