using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using Blazor.Services.Http;
using Domain;
using Domain.DTOs;

namespace Blazor.Services.Http;

public class ChildClient:IChildService
{
    private readonly HttpClient client;
    
    public ChildClient(HttpClient client)
    {
        this.client = client;
    }
    public async Task<Child> CreateAsync(NewChildDTO dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7194/Child/Children", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }
        Child children = JsonSerializer.Deserialize<Child>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return children;
    }
}