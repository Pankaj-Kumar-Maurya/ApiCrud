using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// -------------------- DI (Dependency Injection) --------------------
builder.Services.AddControllers();       // (DI)
builder.Services.AddSwaggerGen();       // (DI)


var connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString)); // (DI)
// -------------------------------------------------------------------

var app = builder.Build();

// ----------------------- Middleware Pipeline ------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();                   // (Middleware)
    app.UseSwaggerUI();                // (Middleware)
}

app.UseHttpsRedirection();             // (Middleware)

app.UseAuthorization();                // (Middleware)

app.MapControllers();                  // (Middleware: Endpoint routing)
// --------------------------------------------------------------------

app.Run();                             // Start the app
