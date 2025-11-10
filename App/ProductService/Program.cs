var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Routing & Middleware
app.UseRouting();
app.UseAuthorization();

// Minimal test route
app.MapGet("/", () => "Hello from ProductService!");

// Map controller routes
app.MapControllers();

app.Run();
