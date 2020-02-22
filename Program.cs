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
			
			
			// string input = Console.ReadLine();

			// grades[3] = int.Parse(input);

			// System.Console.WriteLine(grades[3]);

			// int[] mathStudentsGrades = {20, 13, 21, 50, 9, 10};

			// int[] mathStudentsGradesB = new int[] {20, 10, 6, 7, 30 };

			// System.Console.WriteLine("Length of studen grades {0}", mathStudentsGrades.Length);

			int[] nums = new int[10];

			for(int i = 0; i < nums.Length; i++){
				nums[i] = i;
			}

			for(int j = 0; j < nums.Length; j++){
				System.Console.WriteLine(nums[j]);
			}

			//use counter to get index
			int counter = 0;
			foreach(int k in nums){
				counter = k;
				System.Console.WriteLine("element {0} =  {1}", counter, k);
			}

			string[] friends = new string[5];
			friends[0] = "Brax";
			friends[1] = "Chris";
			friends[2] = "Erika";
			friends[3] = "Tyler";
			friends[4] = "Mike";

			foreach(string x in friends){
				System.Console.WriteLine("Hey there, {0}!", x);
			}

		}
  }
}
