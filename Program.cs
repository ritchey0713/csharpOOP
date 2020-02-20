using System;

namespace oopLearn
{
  class Program {
		static void Main(string[] args) {
			// create a new instance
			Human jon = new Human("John", "Smith");
			//assign member variable
			// jon.firstName = "Jon";
			// jon.lastName = "Smith";
			//call method duh
			jon.IntroduceMyself();

			Human michael = new Human("Michael", "Richards");
			// michael.firstName = "Michael";
			// michael.lastName = "Richards";

			michael.IntroduceMyself();
		}
  }
}
