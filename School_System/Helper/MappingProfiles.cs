using AutoMapper;
using Classes;
using Classes.Models;
using School_System.DTO;

namespace School_System.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
           CreateMap<Administrator, AdministratorDTO>();
           CreateMap<Classroom, ClassroomDTO>().ReverseMap();
           CreateMap<Course, CourseDTO>().ReverseMap();
           CreateMap<Department, DepartmentDTO>();
           CreateMap<Lecturer, LecturerDTO>();
           CreateMap<Office, OfficeDTO>();
           CreateMap<Student, StudentDTO>();
        }   
    }
}
