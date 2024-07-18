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
            StudentService studentService = new StudentService();
            TeacherService teacherService = new TeacherService();
            //var newStudent = new Student
            //{
            //    Name = "Kamal",
            //    TeacherId = 1
            //};
            //studentService.Create(newStudent);

            //var newTeacher = new Teacher
            //{
            //    Id = 2,
            //    Name = "Irade",
            //    Subject = "English2"
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
            //    Console.WriteLine($"Student ID: {student.Id},"+
            //                         $" Name: {student.Name},"+
            //                         $"Age: {student.Age},"+
            //                         $" GPA: {student.GPA}");
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

            ////var student= studentService.GetById(1);
            ////Console.WriteLine(student.Name);
           



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
