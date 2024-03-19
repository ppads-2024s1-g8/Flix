using Contract.Extraction.Api.Application.Gateway;
using Contract.Extraction.Api.Application.Services;
using Contract.Extraction.Api.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flix.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {

        private readonly FilmUserCases _filmUserCases;

        public FilmController(FilmUserCases filmUserCases)
        {
            _filmUserCases = filmUserCases;
        }

        [HttpPost]
        public void PostFilm([FromBody]Filme filmes)
        {
            _filmUserCases.PostFilm(filmes);

        }
    }
}
