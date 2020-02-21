using System;

namespace oopLearn
{
  class Program {
		static void Main(string[] args) {
			// create a new instance
			// Human jon = new Human("John", "Smith", "Blue", 30);
			// //assign member variable
			// // jon.firstName = "Jon";
			// // jon.lastName = "Smith";
			// //call method duh
			// jon.IntroduceMyself();

			// Human michael = new Human("Michael", "Richards", "Brown");
			// michael.firstName = "Michael";
			// michael.lastName = "Richards";

			// michael.IntroduceMyself();

			// Human basic = new Human();

			// basic.IntroduceMyself();

			// Human sarah = new Human("sarah", "Richards");


			// sarah.IntroduceMyself();

			// Human tim = new Human("Tim");


			// tim.IntroduceMyself();

			Box box1 = new Box();
			box1.Length = 10;
			box1.Height = 10;
			box1.Width = 10;
			System.Console.WriteLine("Box volume is {0}", box1.Volume);
			box1.DisplayInfo();
		}
  }
}
