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

			// Box box1 = new Box(10, 10, 10);

			// box1.Width = 20;
			// System.Console.WriteLine("Box volume is {0}", box1.Volume);
			// box1.DisplayInfo();
			// System.Console.WriteLine(box1.FrontSurface);

			// Members member1 = new Members();
			// member1.Introducing(true);

			// creating arrays 
			int[] grades = new int[5];
			grades[0] = 20;
			grades[1] = 15;
			grades[2] = 10;
			grades[3] = 20;
			grades[4] = 10;

			System.Console.WriteLine(grades[3]);
		}
  }
}
