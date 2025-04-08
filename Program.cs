using FFCE.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext para usar SQLite
builder.Services.AddDbContext<FloricultureDataContext>(options =>
    options.UseSqlite("Data Source=Floriculture.db"));

// Adicionar outros serviços (por exemplo, controllers)
builder.Services.AddControllers();

var app = builder.Build();

// Configuração da pipeline de requisição
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
