using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using GraduationProject.DataAccess.Repos;
using GraduationProject.Domain.Models.Identity;
using GraduationProject.Services.IServices;
using GraduationProject.Services.IServices.ComputersServices;
using GraduationProject.Services.Services;
using GraduationProject.Services.Services.ComputersServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IComputersService, ComputersService>();
builder.Services.AddScoped<IUserService, UserService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();


var MainContext = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => 
{
    options.UseSqlServer(MainContext);
});


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment()||app.Environment.IsProduction())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
