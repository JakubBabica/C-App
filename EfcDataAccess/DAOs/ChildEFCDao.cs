using Application.DAOInterfaces;
using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataAccess.DAOs;

public class ChildEFCDao:IChildDAO
{
    private readonly ToyContext toyContext;

    public ChildEFCDao(ToyContext context)
    {
        this.toyContext = context;
    }

    public async Task<Child> createAsync(Child child)
    {
        EntityEntry<Child> newChild = await toyContext.Children.AddAsync(child);
        await toyContext.SaveChangesAsync();
        return newChild.Entity;
    }

    public Task<Child?> getByNameAsync(string Name)
    {
        Child? existing = toyContext.Children.FirstOrDefault(c => c.Name.Equals(Name));
        return Task.FromResult(existing);
    }
}