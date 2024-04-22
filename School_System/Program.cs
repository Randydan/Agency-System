using Classes.Models;
using Microsoft.EntityFrameworkCore;
using School_System.Interfaces;
using School_System.Repository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAdministratorsInterface, AdministratorRepository>();
builder.Services.AddScoped<IClassroomInterface, ClassroomRepository>();
builder.Services.AddScoped<ICourseInterface, CourseRepository>();
builder.Services.AddScoped<IDepartmentInterface, DepartmentRepository>();
builder.Services.AddScoped<ILecturerInterface, LecturerRepository>();
builder.Services.AddScoped<IOfficeInterface, OfficeRepository>();
builder.Services.AddScoped<IStudentInterface, StudentRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<School_ManagementContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolSystemConnection"));
    options.UseSqlServer("Server=KING-DAN;Database=Test;Trusted_Connection=true;");
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

app.Run();