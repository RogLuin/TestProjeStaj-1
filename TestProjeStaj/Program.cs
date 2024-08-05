using Business.Abstract;
using Business.Concrete;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.Extensions.Options;
using static WebApi.Controllers.SurucuController;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<TestProjeDbContext>(options =>
{
    options.UseSqlServer(@"Data Source=DESKTOP-98364GQ\SQLEXPRESS;Initial Catalog=TestProjeStajDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
});
string connectionString = builder.Configuration.GetConnectionString
    ("TestProjeStajDb");
builder.Services.AddHangfire(config=>
{
    config.UseSqlServerStorage(@"Data Source=DESKTOP-98364GQ\SQLEXPRESS;Initial Catalog=TestProjeStajDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
});
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddHangfireServer();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArabaDal, EfArabaDal>();
builder.Services.AddScoped<IArabaService, ArabaManager>();
builder.Services.AddScoped<IArabaSurucuDal, EfArabaSurucuDal>();
builder.Services.AddScoped<IArabaSurucuService, ArabaSurucuManager>();
builder.Services.AddScoped<ISurucuService, SurucuManager>();
builder.Services.AddScoped<ISurucuDal, EfSurucuDal>();
builder.Services.AddScoped<IFirmaDal , EfFirmaDal>();
builder.Services.AddScoped<IFirmaService, FirmaManager>();
builder.Services.AddScoped<IMusteriDal , EfMusteriDal>();
builder.Services.AddScoped<IMusteriService , MusteriManager>();


builder.Services.AddCors(options => options.AddDefaultPolicy(p=>p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();


app.UseHangfireDashboard();
RecurringJob.AddOrUpdate("test-job", () => BackgrounTestServices.Test(),
    Cron.Minutely);
app.UseAuthorization();

app.MapControllers();

app.Run();
