using Microsoft.EntityFrameworkCore;
using WebAPIBiblioteca.Data.Context;
using WebAPIBiblioteca.Services.Implementations.ClienteImplementations;
using WebAPIBiblioteca.Services.Implementations.EmprestimoImplementations;
using WebAPIBiblioteca.Services.Implementations.LivroImplementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SQLServerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection:ConnectionString"));
});

builder.Services.AddScoped<ILivroService, LivroServiceImplementation>();
builder.Services.AddScoped<IClienteService, ClienteServiceImplementation>();
builder.Services.AddScoped<IEmprestimoService, EmprestimoServiceImplementation>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
