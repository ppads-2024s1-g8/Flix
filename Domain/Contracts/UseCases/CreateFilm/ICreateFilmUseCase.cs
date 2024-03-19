namespace Domain.Contracts.UseCases.CreateFilm
{
    public interface ICreateFilmUseCase
    {
        Task<int> CreateAsync(CreateFilmInputDto input, CancellationToken cancellationToken);
    }
}
