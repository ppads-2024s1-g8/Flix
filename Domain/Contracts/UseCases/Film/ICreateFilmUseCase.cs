namespace Domain.Contracts.UseCases.Film
{
    public interface ICreateFilmUseCase
    {
        Task<int> CreateAsync(CreateFilmInputDto input, CancellationToken cancellationToken);
    }
}
