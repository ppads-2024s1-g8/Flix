using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    public User(
        string email,
        string senha,
        string username,
        int diaDeNascimento,
        int mesDeNascimento,
        int anoDeNascimento,
        string cidade,
        string estado
        )
    {
        Email = email;
        Senha = senha;
        Username = username;
        DataDeNascimento = new DataDeNascimento
        {
            Dia = diaDeNascimento,
            Mes = mesDeNascimento,
            Ano = anoDeNascimento
        };
        Cidade = cidade;
        Estado = estado;
    }

    [Key]
    public int Id { get; init; }
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public string Username { get; set; } = default!;
    public DataDeNascimento DataDeNascimento { get; set; } = new DataDeNascimento();
    public string Cidade { get; set; } = default!;
    public string Estado { get; set; } = default!;
}

public class DataDeNascimento
{
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
}
