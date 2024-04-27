namespace School_System.DTO
{
    public class ClassroomDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string CourseCode { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
