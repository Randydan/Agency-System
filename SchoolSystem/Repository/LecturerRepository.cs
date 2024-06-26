﻿using Code_First.Models;
using SchoolSystem.Interfaces;

namespace SchoolSystem.Repository
{
    public class LecturerRepository : ILecturerInterface
    {
        private readonly CodeFirstContext _context;

        public LecturerRepository(CodeFirstContext context)
        {
                _context = context;
        }

        public bool CreateLecturer(Lecturer lecturer)
        {
            _context.Add(lecturer);

            return Save();
        }

        public bool DeleteLecturer(Lecturer lecturer)
        {
            _context.Remove(lecturer);
            return Save();
        }

        public Lecturer GetLecturer(string name)
        {
            return _context.Lecturers.Where(p=>p.Name == name).FirstOrDefault();
        }

        public Lecturer GetLecturer(int id)
        {
            return _context.Lecturers.Where(p=>p.Id==id).FirstOrDefault();
        }

        public ICollection<Lecturer> GetLecturers()
        {
            return _context.Lecturers.OrderBy(p=>p.Id).ToList();
        }

        public bool LecturerExists(int id)
        {
           return _context.Lecturers.Any(p=> p.Id==id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateLecturer(Lecturer lecturer)
        {
            _context.Update(lecturer);
            return Save();
        }
    }
}
