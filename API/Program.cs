using API.Data;
using API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var SolicConnectionString = builder.Configuration.GetConnectionString("SolicAdopConnection");
var UsuarioConnectionString = builder.Configuration.GetConnectionString("UsuarioConnection");

// Add services to the container.

builder.Services.AddDbContext<UsuarioContext>(opts => opts.UseMySql(UsuarioConnectionString, ServerVersion.AutoDetect(UsuarioConnectionString)));

builder.Services.AddDbContext<SolicAdopContext>(opts => opts.UseLazyLoadingProxies().UseMySql(SolicConnectionString, ServerVersion.AutoDetect(SolicConnectionString)));

builder.Services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<UsuarioContext>()
                .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
