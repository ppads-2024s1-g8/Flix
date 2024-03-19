using Domain.Contracts.UseCases.CreateFilm;
using Microsoft.AspNetCore.Mvc;

namespace Flix.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly ICreateFilmUseCase _createFilmUseCase;

        public FilmController(ICreateFilmUseCase createFilmUseCase)
        {
            _createFilmUseCase = createFilmUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> CreateFilmAsync([FromBody] CreateFilmInputDto input, CancellationToken cancellationToken)
        {
            try
            {
                var filmId = await _createFilmUseCase.CreateAsync(input, cancellationToken);

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
    }
}
