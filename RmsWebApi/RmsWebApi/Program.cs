using Microsoft.EntityFrameworkCore;
using RmsWebApi;
using RmsWebApi.Repository;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
using Microsoft.EntityFrameworkCore.Proxies;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddLog4Net(new Log4NetProviderOptions("log4net.config"));
// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("RMSDbConnection");
builder.Services.AddDbContext<RMSContext>(options =>

options.UseLazyLoadingProxies().UseSqlServer(connectionString)

);

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IResumeRepository, ResumeRepository>();
builder.Services.AddTransient<IRoleMaster, RoleMasterRepository>();
builder.Services.AddTransient<IDesignationMaster, DesignationMasterRepository>();
builder.Services.AddTransient<IProjectMaster, ProjectMasterRepository>();
builder.Services.AddTransient<ITechStackMaster, TechStackMasterRepository>();
builder.Services.AddTransient<ITechStackValue, TechStackValueRepository>();
builder.Services.AddTransient<ISkillsMaster, SkillsMasterRepository>();

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddCors();

//builder.Services.AddControllersWithViews().AddJsonOptions(options =>
//options.JsonSerializerOptions.ReferenceHandler = options.JsonSerializerOptions.ReferenceHandler ?? ReferenceHandler.IgnoreCycles)
//.AddJsonOptions(options => options.JsonSerializerOptions.PropertyNameCaseInsensitive = true);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalErrorMiddleware>();

app.MapControllers();

app.Run();