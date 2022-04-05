using Microsoft.EntityFrameworkCore;
using RmsWebApi.Repository;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddLog4Net(new Log4NetProviderOptions("log4net.config"));

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("RMSDbConnection");
builder.Services.AddDbContext<RMSContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IResumeRepository, ResumeRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


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
