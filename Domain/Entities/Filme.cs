using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    [Key]
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Diretor do filme é obrigatório")]
    public string Diretor { get; set; }
    [Required(ErrorMessage = "O Elenco do filme é obrigatório")]
    public string Elenco { get; set; }
    [Required(ErrorMessage = "O Pais do filme é obrigatório")]
    public string Pais { get; set; }
    [Required(ErrorMessage = "O Ano do filme é obrigatório")]
    public int Ano { get; set; }


}
    