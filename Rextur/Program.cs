using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using Rextur.Configuration;
using Rextur.Data;
using Rextur.Domain.Interfaces;
using Rextur.Infra.ExternalServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];

//builder.Services.AddDbContext<PassageirosContext>
//   (options => options.UseMySql(connection,
//       Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.2.42-mysql")));
builder.Services.AddHttpClient();

builder.Services.ResolveDependencies(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
