using Microsoft.EntityFrameworkCore;
using todolist_api.Modelos;

var builder = WebApplication.CreateBuilder(args);

// ── Servicios ──────────────────────────────────────────────────
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TareasContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));
});

// Permite que el HTML del wwwroot llame a la API sin errores de CORS
// (util si alguna vez abres el HTML desde otro origen)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// ── Pipeline ───────────────────────────────────────────────────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sirve los archivos estaticos de la carpeta wwwroot/
app.UseStaticFiles();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();