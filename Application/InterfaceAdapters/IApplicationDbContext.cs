using Contract.Extraction.Api.Domain.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flix.Application.InterfaceAdapters;

public interface IApplicationDbContext
{
    DbSet<Filme> Filme { get; }
    DbSet<Book> Livro { get; }
    DbSet<Series> Serie { get; }
    DbSet<User> Usuario { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}
