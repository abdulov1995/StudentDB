using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace PostgresEFConsoleApp
{
    public class StudentService
    {
        AppDbContext context = new();
        public Student GetById(int studentId)
        {
            var student = context.Students.Include(s => s.Teacher).FirstOrDefault(s => s.Id == studentId);
            return student;
        }
        public List<Student> GetAll()
        {
            var students = context.Students.Include(s=>s.Teacher).ToList();
            return students;
        }
        public void Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void Update(int id, Student updatedStudent)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.GPA = updatedStudent.GPA;

            context.Students.Update(student);
            context.SaveChanges();
        }
        public void Delete(int studentId)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == studentId);
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
    
}
