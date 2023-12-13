using Api.Tareas.Negocio;
using Api.Tareas.Negocio.Implements;
using Api.Tareas.Persistencia;
using Api.Tareas.Repositorio;
using Api.Tareas.Repositorio.Implements;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContextPool<TaskContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conexionsql")));
builder.Services.AddCors(options => options.AddPolicy("corsapp", x => x.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()));

builder.Services.AddTransient<INotaRepositorio,NotaRepositorio>();
builder.Services.AddTransient<INotaNegocio,NotaNegocio>();

builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddTransient<IUsuarioNegocio, UsuarioNegocio>();



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

app.UseCors();

app.MapControllers();

app.Run();
