using Application.DAOInterfaces;
using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class ToyEFCDao:IToyDao
{
    private readonly ToyContext toyContext;

    public ToyEFCDao(ToyContext context)
    {
        this.toyContext = context;
    }

    public async Task<Toy> createAsync(Toy toy)
    {
        EntityEntry<Toy> newToy = await toyContext.Toys.AddAsync(toy);
        await toyContext.SaveChangesAsync();
        return newToy.Entity;
    }
}