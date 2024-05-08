using Data;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// set db connection
builder.Services.AddDbContext<EcommerceContext>(opts =>
    opts.UseNpgsql(builder.Configuration.GetConnectionString("EcommerceConnection"))
);

// set automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// set services classes injection
builder.Services.AddScoped<ProductService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers();

app.Run();
