using Microsoft.EntityFrameworkCore;
using RectangleSearch.Data;
using RectangleSearch.Middlewares;
using RectangleSearch.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IRectangleService, RectangleService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseMiddleware<ApiKeyMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("matching-rectangles",
   async (IRectangleService rectangleService,int x, int y) => 
      Results.Ok(await Task.Run(() => rectangleService.FindMatchingRectangles(x,y))));

app.Run();
