using Application.DAOInterfaces;
using Application.Logic;
using Application.LogicInterfaces;
using Blazor.Services;
using Blazor.Services.Http;
using EfcDataAccess;
using EfcDataAccess.DAOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<ToyContext>();
builder.Services.AddScoped<IChildService, ChildClient>();
builder.Services.AddScoped<IToyDao, ToyEFCDao>(); 
builder.Services.AddScoped<IChildDAO, ChildEFCDao>(); 
builder.Services.AddScoped<IToyLogic, ToyLogic>(); 
builder.Services.AddScoped<IChildLogic, ChildLogic>();
builder.Services.AddScoped(sp=>new HttpClient
    {
        BaseAddress = new Uri("http://localhost:7145")
    
    }
);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();