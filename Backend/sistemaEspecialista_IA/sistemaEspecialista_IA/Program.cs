using Microsoft.EntityFrameworkCore;
using sistemaEspecialista_IA.Data;
using sistemaEspecialista_IA.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. CONFIGURAÇÃO DOS SERVIÇOS (Dependency Injection)

builder.Services.AddControllers();

// Configura o Swagger (Documentação)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura o Banco de Dados SQLite
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

// Registra o Motor de Inferência para que o Controller possa usá-lo
builder.Services.AddScoped<MotorDeInferencia>();

// Configura o CORS para permitir que o React (porta 5173) acesse a API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// 2. CONFIGURAÇÃO DO PIPELINE DE EXECUÇÃO (Middlewares)

// Ativa o Swagger em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// IMPORTANTE: O CORS deve vir ANTES do Authorization e dos Maps
app.UseCors("AllowReact");

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia os endpoints dos Controllers
app.MapControllers();

app.Run();