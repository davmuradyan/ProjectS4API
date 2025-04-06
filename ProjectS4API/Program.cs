using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Add DbContext with SQL Server connection
builder.Services.AddDbContext<MainDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainConnectionString")));

// Add services
//builder.Services.AddScoped<IStopService, StopService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS before Authorization
app.UseCors("CorsPolicy");
app.UseCors("AllowLocalhost");
app.UseAuthorization();

app.MapControllers();

app.Run();