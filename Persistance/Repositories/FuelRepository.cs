using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistence.Repositories;

public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
{
    public FuelRepository(BaseDbContext context) : base(context)
    {
    }
}
