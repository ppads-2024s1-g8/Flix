using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Extraction.Api.Domain.Entities;

namespace Contract.Extraction.Api.Application.Gateway;
public interface IFilmRepository
{
    public void DeleteFilm(string nome);
    public Filme GetFilm(string nome);
    public void PostFilm(Filme filme);
    public void PutFilm(string titulo, string diretor, string elenco, string pais, int ano);
}
