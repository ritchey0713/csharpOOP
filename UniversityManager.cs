using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopLearn
{
  class UniversityManager
  {
    public List<University> universities;
    public List<Student> students;

    // constructor
    public UniversityManager()
    {
      universities = new List<University>();
      students = new List<Student>();

      universities.Add(new University { Id = 1, Name = "Osu" });
      universities.Add(new University { Id = 1, Name = "Stanford" });

      students.Add(new Student { Id = 1, Name = "John", Gender = "Male", Age = 22, UniversityId = 1 });
      students.Add(new Student { Id = 2, Name = "Sarah", Gender = "Female", Age = 19, UniversityId = 2 });
      students.Add(new Student { Id = 3, Name = "Sal", Gender = "Male", Age = 23, UniversityId = 1 });
     
      students.Add(new Student { Id = 4, Name = "Terry", Gender = "Male", Age = 30, UniversityId = 2 });
      students.Add(new Student { Id = 5, Name = "Sam", Gender = "Female", Age = 27, UniversityId = 1 });

    }

    public void MaleStudents()
    {
      IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
      Console.WriteLine("Male students");

      foreach(Student student in maleStudents)
      {
        student.Print();
      }
    }

  } // end university manager
}
