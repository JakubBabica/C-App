using Domain;
using Domain.DTOs;

namespace Blazor.Services;

public interface IChildService
{
    public Task<Child> CreateAsync(NewChildDTO dto);
}