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
			// int[] grades = new int[5];
			// grades[0] = 20;
			// grades[1] = 15;
			// grades[2] = 10;
			// grades[3] = 20;
			// grades[4] = 10;

			// System.Console.WriteLine(grades[3]);
			
			
			// // string input = Console.ReadLine();

			// // grades[3] = int.Parse(input);

			// // System.Console.WriteLine(grades[3]);

			// // int[] mathStudentsGrades = {20, 13, 21, 50, 9, 10};

			// // int[] mathStudentsGradesB = new int[] {20, 10, 6, 7, 30 };

			// // System.Console.WriteLine("Length of studen grades {0}", mathStudentsGrades.Length);

			// int[] nums = new int[10];

			// for(int i = 0; i < nums.Length; i++){
			// 	nums[i] = i;
			// }

			// for(int j = 0; j < nums.Length; j++){
			// 	System.Console.WriteLine(nums[j]);
			// }

			// //use counter to get index
			// int counter = 0;
			// foreach(int k in nums){
			// 	counter = k;
			// 	System.Console.WriteLine("element {0} =  {1}", counter, k);
			// }

			// string[] friends = new string[5];
			// friends[0] = "Brax";
			// friends[1] = "Chris";
			// friends[2] = "Erika";
			// friends[3] = "Tyler";
			// friends[4] = "Mike";

			// foreach(string x in friends){
			// 	System.Console.WriteLine("Hey there, {0}!", x);
			// }

			// // declare 2d array 
			// string[,] matrix;

			// // doesnt work
			// // matrix = {
			// // 	{"1", "2"},
			// // 	{"3", "4"}
			// // }

			// //3d array 
			// int[,,] threeD;

			// //2d array 
			// int[,] array2D = new int[,] {
			// 	{
			// 		1, 2, 3 // row 0
			// 	},
			// 	{
			// 		4, 5, 6 //row 1
			// 	},
			// 	{
			// 		7, 8, 9  //row 2
			// 	}
			// };

			// System.Console.WriteLine("central value is {0}", array2D[1,1]);

			// //3d array must have same amount of rows in both
			// string[,,] array3D = new string[,,] {
			// 	{
			// 		{
			// 			"1", "2", "3"
			// 		},
			// 		{
			// 			"4", "5", "6"
			// 		},
			// 		{
			// 			"Hello!", "Hi", "what's up!"
			// 		}
			// 	},
			// 	{
			// 		{
			// 			"10", "11", "12"
			// 		},
			// 		{
			// 			"13", "14", "15"
			// 		},
			// 		{
			// 			"Goodbye!", "see ya!", "Later!"
			// 		}
			// 	}
			// };

			// System.Console.WriteLine("to get the 5 is {0}", array3D[0,1,1]);

			// System.Console.WriteLine("to get the 11 is {0}", array3D[1,0,1]);

			// System.Console.WriteLine("Say {0}!", array3D[0,2,0]);

			// System.Console.WriteLine("and now say {0}!", array3D[1,2,0]);


			// //specify demensions of matrix 

			// string[,] array2D2 = new string[3,2]{
			// 	{
			// 		"1", "2"
			// 	},
			// 	{
			// 		"3", "4"
			// 	},
			// 	{
			// 		"5", "6"
			// 	}
			// };

			// array2D2[1,1] = "Chicken!";
			// System.Console.WriteLine(array2D2[1,1]);

			// //find matrix dimensions 
			// int demensions = array2D2.Rank;

			// System.Console.WriteLine("Dementions are {0}", demensions);

			// string[,] array2D3 = {
			// 	{
			// 		"1", "2"
			// 	},
			// 	{
			// 		"3", "4"
			// 	},
			// 	{
			// 		"5", "6"
			// 	}
			// };

			int[][] jaggedArr = new int[3][];
			jaggedArr[0] = new int [5];
			jaggedArr[1] = new int [3];
			jaggedArr[2] = new int [1];

			//initalizer 
			jaggedArr[0] = new int[] {2,4,5,6,7};
			jaggedArr[1] = new int[] {6,7,8};
			jaggedArr[2] = new int[] {1};

			//alt way 
			int[][] jaggedarr2 = new int[][]{
				new int[] {2,4,5,6,7},
				new int[] {10, 100, -7}
			};

			// System.Console.WriteLine("the value of the middle element in the second array is {0}", jaggedarr2[1][1]);

			foreach(int [] array in jaggedarr2){
				foreach(int ele in array){
					System.Console.WriteLine(ele);
				}
			}


				// for(int i = 0; i < jaggedarr2.Length; i++){
				// 	System.Console.WriteLine("ARRAY NUM: {0}", i);
				// 	for(int j = 0; j < jaggedarr2[i].Length; j++){
				// 		System.Console.WriteLine("ELE VALUE: {0}", jaggedarr2[i][j]);
				// 	}
				// }

				string[][] jaggedarr3 = new string[][]{
					new string[] {"Derek", "Doug", "Mrs. Maynard"},
					new string[] {"Chris", "Mr. Hellickson", "Mrs. Hellickson"},
					new string[] {"Mike", "Mr. Smith", "Mrs. Smith"}
				};

				for(int i = 0; i < jaggedarr3.Length; i++){
						System.Console.WriteLine("My name is {0}", jaggedarr3[i][i]);
					for(int j = 0; j < jaggedarr3[i].Length; j++){
						System.Console.WriteLine("Hey! My name is {0}", jaggedarr3[j][j]);
					}

				}


		}
  }
}
