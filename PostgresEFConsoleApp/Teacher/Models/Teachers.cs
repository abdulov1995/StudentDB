using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Teacher
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Subject { get; set; }

    public ICollection<Student> Students { get; set; } 
}
