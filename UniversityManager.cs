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

    public void FemaleStudents()
    {
      IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
      
      foreach(Student student in femaleStudents)
      {
        student.Print();
      }
    
    }

    public void SortStudentsByAge()
    {
      // this is ookay but typically runs slower/ is lazier
      var sortedStudents = from student in students orderby student.Age select student; 

        Console.WriteLine("Sorted by age");
      foreach(Student student in sortedStudents)
      {
        student.Print();
      }
    }

    public void AllStudentsFromOsu()
    {
      IEnumerable<Student> OsuStudents = from student in students
                                         join university in universities on student.UniversityId
                                         equals university.Id
                                         where university.Name == "Osu"
                                         select student;

      Console.WriteLine("Students from OSU");
      foreach(Student student in OsuStudents)
      {
        student.Print();
      }
    }

    public void FindStudentsBySchoolId(string input)
    {
      int id;
      Int32.TryParse(input, out id);
      if(id > 0)
      {
        //IEnumerable<Student> foundStudents = from student in students
        //                                     join university in universities on student.UniversityId
        //                                     equals university.Id
        //                                     where university.Id == id
        //                                     select student;

        IEnumerable<Student> foundStudents = from student in students
                                             where student.UniversityId == id
                                             select student;

        Console.WriteLine("Found students:");
        foreach(Student student in foundStudents)
        {
          student.Print();
        }
      }
      else
      {
        Console.WriteLine("Oops bad id given");
      }
    }

  } // end university manager
}
