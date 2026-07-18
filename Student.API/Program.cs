using Student.API.Interfaces; //added
using Student.API.Services;   //added
using Student.API.Repositories;   //added
using Microsoft.EntityFrameworkCore;  //added for ef
using Student.API.Data; ////added for ef

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IStudentService, StudentService>(); //added
builder.Services.AddScoped<IStudentRepository, StudentRepository>(); //added after line istudentservice 
builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //added later but 3rd in sequence
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// COMMENTED BY G app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
