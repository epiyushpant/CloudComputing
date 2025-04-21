var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

// Correct middleware order
app.UseRouting();
app.UseAuthorization();

// Minimal test route
app.MapGet("/", () => "Hello from userService!");
app.MapControllers();

app.Run();