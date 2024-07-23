using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostgresEFConsoleApp
{
    public class TeacherStudentService
    {
        AppDbContext context = new();
        public void Create(TeacherStudent teacherStudent)
        {
            context.TeacherStudents.Add(teacherStudent);
            context.SaveChanges();
        }//ref table not working 
        public List<TeacherStudent> GetTeacherStudents()
        {
          return context.TeacherStudents.Include(ts => ts.Teacher)
                .Include(ts => ts.Student)
                .ToList();
        }
        public List<TeacherStudent>GetTeacherStudentsById(int teacherId)//or student id?
        {
            return context.TeacherStudents.Include(ts => ts.Teacher)
               .Include(ts => ts.Student)
               .Where(ts => ts.TeacherId == teacherId)
               .ToList();
        }
        public void Delete(int teacherId) //default id for StudentId ?
        {
            var teacherStudent = context.TeacherStudents.FirstOrDefault(ts => ts.TeacherId == teacherId);
            context.TeacherStudents.Remove(teacherStudent);
            context.SaveChanges();
        } 
        public void Update(int teacherId, int studentId, TeacherStudent teacherStudent)
        {
           var newInput= context.TeacherStudents.Include(ts => ts.Teacher) 
                                                .Include(ts => ts.Student)
                                                .FirstOrDefault(ts => ts.TeacherId == teacherId && ts.StudentId == studentId);
            newInput.Teacher.Name = teacherStudent.Teacher.Name;
            newInput.Teacher.Subject = teacherStudent.Teacher.Subject;
            newInput.Student.Name = teacherStudent.Student.Name;
            newInput.Student.Age = teacherStudent.Student.Age;
            newInput.Student.GPA = teacherStudent.Student.GPA;
           
            context.TeacherStudents.Update(newInput);
            context.SaveChanges();
        }
    }
}
