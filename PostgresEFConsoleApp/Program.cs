using Microsoft.EntityFrameworkCore;
using PostgresEFConsoleApp;
using StudentDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppWithEF
{
    class Program
    {
        static void Main(string[] args)
        {

            TeacherStudentService teacherStudentService = new TeacherStudentService();
            //StudentService studentService = new StudentService();
            //TeacherService teacherService = new TeacherService();

            //var newTeacher = new Teacher { Name = "Mirze", Subject = "Fizika" };
            //teacherService.Create(newTeacher);
            //var newStudent = new Student {  Name = "Ferid", Age = 29, GPA = 5 };
            //studentService.Create(newStudent);

            //var teacherStudent = new TeacherStudent
            //{
            //    TeacherId = newTeacher.Id,
            //    StudentId = newStudent.Id
            //};
            //teacherStudentService.Create(teacherStudent);


            //var teacherStudent = teacherStudentService.GetTeacherStudents();

            //foreach (var teacherstudent in teacherStudent)
            //{
            //    Console.WriteLine($"Teacher: {teacherstudent.Teacher.Name}, {teacherstudent.Teacher.Subject}");
            //    Console.WriteLine($"Student: {teacherstudent.Student.Name}, {teacherstudent.Student.Age}, {teacherstudent.Student.GPA}");
            //    Console.WriteLine(); 
            //}
            //teacherStudentService.GetTeacherStudents();



            //var teacherStudent = teacherStudentService.GetTeacherStudentsById(1);
            //foreach (var teacherstudent in teacherStudent)
            //{
            //    Console.WriteLine($"Teacher: {teacherstudent.Teacher.Name}, {teacherstudent.Teacher.Subject}");
            //    Console.WriteLine($"Student: {teacherstudent.Student.Name}, {teacherstudent.Student.Age}, {teacherstudent.Student.GPA}");
            //    Console.WriteLine();
            //}

            //teacherStudentService.Delete(0,11);
            


            //var updatedTeacher = new Teacher { Name = "Aysel", Subject = "Cografiya" };
            //var updatedStudent = new Student { Name = "Cingiz", Age = 25 };
            //var teacherStudent = new TeacherStudent
            //{
            //    Teacher = updatedTeacher,
            //    Student = updatedStudent
            //};
            //teacherStudentService.Update(1, 1, teacherStudent);




            //var newStudent = new Student
            //{
            //    Name = "Rauf",
            //    Age=28,

            //};
            //studentService.Create(newStudent);

            //var newTeacher = new Teacher
            //{
            //    Name = "Arzu",
            //    Subject = "English"
            //};
            //teacherService.Create(newTeacher);


            //var updatedStudent = new Student
            //{
            //    Name = "Asif",
            //    Age=30,
            //    GPA=4,
            //    TeacherId = 1
            //};
            //studentService.Update(2, updatedStudent);

            //var updatedTeacher = new Teacher
            //{
            //    Name="Aysel",
            //    Subject="Cebr"
            //};
            //teacherService.Update(2, updatedTeacher);


            //var students = studentService.GetAll();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Student ID: {student.Id}," +
            //                         $" Name: {student.Name}," +
            //                         $"Age: {student.Age}," +
            //                         $" GPA: {student.GPA}");

            //    Console.WriteLine("Teacher name is " +  student.Teacher.Name);
            //};

            //var teachers = teacherService.GetAll();
            //foreach (var teacher in teachers)
            //{
            //    Console.WriteLine($"Teacher: {teacher.Name},Subject:{teacher.Subject}");
            //    foreach (var student in teacher.Students)
            //    {
            //        Console.WriteLine($"Student ID: {student.Id}," +
            //                        $" Name: {student.Name}, " +
            //                        $"Age: {student.Age}," +
            //                        $" GPA: {student.GPA}");
            //    }
            //};


            // teacherService.Delete(2);

            //var student = studentService.GetById(1);
            //Console.WriteLine($" Student name  is {student.Name} \n " +
            //                  $"This student's teacher name is {student.Teacher.Name}");

            //var teacher = teacherService.GetById(1);
            //Console.WriteLine(teacher.Name);
            //foreach (var student in teacher.Students)
            //{
            //    Console.WriteLine($"Student ID: {student.Id}," +
            //                       $" Name: {student.Name}, " +
            //                       $"Age: {student.Age}," +
            //                       $" GPA: {student.GPA}");
            //}
        }
    }

}
