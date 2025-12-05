var builder = WebApplication.CreateBuilder(args);

// -------------------- DI (Dependency Injection) --------------------
builder.Services.AddControllers();       // (DI)
builder.Services.AddSwaggerGen();       // (DI)
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
