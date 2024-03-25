using Contract.Extraction.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flix.Application.InterfaceAdapters;

public interface IApplicationDbContext
{
    DbSet<Filme> Filme { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}
