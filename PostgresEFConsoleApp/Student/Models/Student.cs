using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal? GPA { get; set; }

    public ICollection<TeacherStudent> TeacherStudents { get; set; }
}
