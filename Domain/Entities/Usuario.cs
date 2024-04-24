using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;


public class Usuario
{
    public Usuario(
        string email,
        string senha,
        string usuarioname,
        DateTime dataDeNascimento,
        string cidade,
        string estado
        )
    {
        Email = email;
        Senha = senha;
        Usuarioname = usuarioname;
        DataDeNascimento = dataDeNascimento;
        Cidade = cidade;
        Estado = estado;
    }

    [Key]
    public int Id { get; init; }
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public string Usuarioname { get; set; } = default!;
    public DateTime DataDeNascimento { get; set; } = default!;
    public string Cidade { get; set; } = default!;
    public string Estado { get; set; } = default!;
}

