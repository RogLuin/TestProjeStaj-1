using Business.Abstract;
using Business.Concrete;
using Business.UnitOfWorks;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TestProjeDbContext>(options =>
{
    options.UseSqlServer(@"Data Source=DESKTOP-98364GQ\SQLEXPRESS;Initial Catalog=TestProjeStajDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
