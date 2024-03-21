using System.Threading;
using Contract.Extraction.Api.Domain.Entities;
using Domain.Contracts.UseCases.Film;
using Infra.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Flix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmUseCase _FilmUseCase;

        public FilmController(IFilmUseCase createFilmUseCase)
        {
            _FilmUseCase = createFilmUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> CreateFilmAsync([FromBody] FilmInputDto input, CancellationToken cancellationToken)
        {
            try
            {
                var filmId = await _FilmUseCase.CreateAsync(input, cancellationToken);

                return Ok(
                    new
                    {
                        FilmId = filmId
                    });
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFilmAsync(CancellationToken cancellationToken)
        {
            try
            {
                var filmList = await _FilmUseCase.GetAllAsync(cancellationToken);

                return Ok(filmList);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        //[HttpGet]
        //[Route("{id: int}")]
        //public async Task<IActionResult> GetByIdFilmAsync(CancellationToken cancellationToken)
        //{
        //    try
        //    {    
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Problem(ex.Message);
        //    }
        //}

        [HttpDelete]
        public async Task<IActionResult> DeleteByIdFilmAsync(int id, CancellationToken cancellationToken)
        {
            try
            {
                var deletedFilm = await _FilmUseCase.DeleteByIdFilmAsync(id, cancellationToken);

                return Ok(deletedFilm);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

    }
}
