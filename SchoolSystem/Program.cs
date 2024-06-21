using Code_First.Models;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Interfaces;
using SchoolSystem.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CodeFirstContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));
builder.Services.AddControllers();
builder.Services.AddScoped<IAdministratorInterface, AdministratorsRepository>();
builder.Services.AddScoped<IClassroomInterface, ClassroomRepository>();
builder.Services.AddScoped<ICourseInterface, CourseRepository>();
builder.Services.AddScoped<IDepartmentInterface, DepartmentRepository>();
builder.Services.AddScoped<ILecturerInterface, LecturerRepository>();
builder.Services.AddScoped<IOfficeInterface, OfficeRepository>();
builder.Services.AddScoped<IStudentInterface, StudentRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("default", policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

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

app.UseCors("default");

app.Run();
