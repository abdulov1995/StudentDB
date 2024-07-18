using PostgresEFConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentDB
{
    public class TeacherService
    {
        AppDbContext context = new();
        public Teacher GetById(int teacherId)
        {
            var teacher = context.Teacher.Include(t=>t.Students).FirstOrDefault(s => s.Id == teacherId);
            return teacher;
        }
        public List<Teacher> GetAll()
        {
            var teachers = context.Teacher.Include(t => t.Students).ToList();
            return teachers;
        }
        public void Create(Teacher teacher)
        {
            context.Teacher.Add(teacher);
            context.SaveChanges();
        }
        public void Update(int id, Teacher updatedTeacher)
        {
            var teacher = context.Teacher.FirstOrDefault(t => t.Id == id);
            teacher.Name = updatedTeacher.Name;
            teacher.Subject = updatedTeacher.Subject;

            context.Teacher.Update(teacher);
            context.SaveChanges();
        }
        public void Delete(int teacherId)
        {
            var teacher = context.Teacher.FirstOrDefault(t => t.Id == teacherId);
            context.Teacher.Remove(teacher);
            context.SaveChanges();
        }
    }
}
