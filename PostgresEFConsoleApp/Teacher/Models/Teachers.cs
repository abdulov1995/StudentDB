using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Teacher
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Subject { get; set; }
    [Required]
    public int StudentId { get; set; }

    public ICollection<TeacherStudent> TeacherStudents { get; set; }
}
