using System;
using System.Collections.Generic;
using System.Text;

namespace oopLearn
{
  class University
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public void Print()
    {
      Console.WriteLine("University {0} with id of {1}", Name, Id);
    }
  }
}
