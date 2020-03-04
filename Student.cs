using System;
using System.Collections.Generic;
using System.Text;

namespace oopLearn
{
  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    // foreign key 
    public int UniversityId { get; set; }

    public void Print()
    {
      Console.WriteLine("Student {0}, with id {1}, gender {2} age {3} university id {4}", 
        Name, Id, Gender, Age, UniversityId);
    }
  }
}
