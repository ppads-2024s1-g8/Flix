﻿namespace Domain.Contracts.UseCases.CreateFilm;

public class CreateFilmInputDto
{
    public string Titulo { get; init; } = default!;
    public string Diretor { get; init; } = default!;
    public string Elenco { get; init; } = default!;
    public string Pais { get; init; } = default!;
    public int Ano { get; init; }
}
