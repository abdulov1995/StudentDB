using Microsoft.EntityFrameworkCore;
using PostgresEFConsoleApp;
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
            //var newStudent = new Student
            //{
            //    Name = "Kamal",
            //    TeacherId = 1
            //};
            //studentService.Create(newStudent);


            //var updatedStudent = new Student
            //{
            //    Name = "Xalid",
            //    TeacherId = 1
            //};
            //studentService.Update(2, updatedStudent);



            //var students = studentService.GetAll();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Student ID: {student.Id}," +
            //                         $" Name: {student.Name}, " +
            //                         $"Age: {student.Age}," +
            //                         $" GPA: {student.GPA}");
            //};

            
           
           var student= studentService.GetById(1);
           Console.WriteLine(student.Name);

        }
    }

 }
   