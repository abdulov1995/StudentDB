using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TeacherStudent
{
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public int StudentId { get; set; }

    public Teacher Teacher { get; set; }
    public Student Student { get; set; }
}

