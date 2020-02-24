using System;
using System.Collections;
using System.Collections.Generic;

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

				// string[][] jaggedarr3 = new string[][]{
				// 	new string[] {"Derek", "Doug", "Mrs. Maynard"},
				// 	new string[] {"Chris", "Mr. Hellickson", "Mrs. Hellickson"},
				// 	new string[] {"Mike", "Mr. Smith", "Mrs. Smith"}
				// };

				// for(int i = 0; i < jaggedarr3.Length; i++){
				// 		System.Console.WriteLine("My name is {0}", jaggedarr3[i][i]);
				// 	for(int j = 0; j < jaggedarr3[i].Length; j++){
				// 		System.Console.WriteLine("Hey! My name is {0}", jaggedarr3[j][j]);
				// 	}

				// }

			int[] grades = new int[] {15, 13, 6, 12, 6, 16};

			foreach(int grade in grades){
				System.Console.WriteLine("  {0}   ", grade);
			}

			double results = GetAverage(grades);
			System.Console.WriteLine("average is {0}", results);

			int[] happiness = new int[] {
				1,
				2,
				3,
				4,
				5
			};


			// getHappiness(happiness);

			// foreach(int stage in happiness){
			// 	System.Console.WriteLine("Stage of happiness: {0}", stage);
			// }

			//declaring an arrayList with undefined amount of objs 
			ArrayList myArrayList = new ArrayList();

			//defined amount of objs 
			ArrayList myArrayList2 = new ArrayList(100);

			myArrayList.Add(25);
			myArrayList.Add("Hello");
			myArrayList.Add(25);
			myArrayList.Add(13);
			myArrayList.Add(6.7453);
			myArrayList.Add("Bye");
			myArrayList.Add(13);

			// delete element by pass passing value to Remove
			myArrayList.Remove(13);

			//delete ele at specific index 
			myArrayList.RemoveAt(0);


			System.Console.WriteLine("COUNT: {0}", myArrayList.Count);

			double sum = 0;

			// use object class type for array lists
			// foreach(object obj in myArrayList){
			// 	if(obj is int){
			// 		sum += Convert.ToDouble(obj);
			// 	} else if (obj is double) {
			// 		sum += (double)obj;
			// 	} else if (obj is string){
			// 		System.Console.WriteLine("STR {0}", obj);
			// 	}
			// }

			// System.Console.WriteLine("SUM {0}", sum);

			//list 
			List<int> list = new List<int> {1,2,3,4,5};
			//adds to end of the list 
			list.Add(0);
			list.Add(6);
			list.Sort();
			list.RemoveRange(0,2);

			foreach(int i in list){
				System.Console.WriteLine("Num: {0}", i);
			}

			System.Console.WriteLine(list.Contains(4));
			// find index of element matching expression, ie what index is the num 4 located at
			int index = list.FindIndex(x => x == 4);
			
			System.Console.WriteLine(list[index]);

			list.RemoveAt(index);

			list.ForEach(i => System.Console.WriteLine(i));

			//array list 
			ArrayList arrayList4 = new ArrayList();
			arrayList4.Add(1);
			arrayList4.Add(10);
			arrayList4.Add("3");
			arrayList4.Add(new Number {n = 4} );

			foreach(object o in arrayList4){
				System.Console.WriteLine(o);
			}

			Post post1 = new Post("New Post", true, "Anon");
			System.Console.WriteLine(post1.ToString());

			ImagePost post2 = new ImagePost("Image", "anon", "Image url" ,true );

			System.Console.WriteLine(post2.ToString());

			VideoPost post3  = new VideoPost("video", "Youtube", "google.com", 2000, true);
			//System.Console.WriteLine(post3.ToString());

			post3.PlayVideo();

			System.Console.WriteLine("Press any key to pause");
			string input = Console.ReadLine();
			post3.StopVideo();
			
			// if (input.ToLower().Equals("play")){
			// 	post3.PlayVideo();
			// }
			
		}

		class Number {
			public int n {get; set;}


			// NEED THIS TO GET THAT ARRAYLIST TO PRINT NUM 4
			public override string ToString(){
				return n.ToString();
			}
		}

			static double GetAverage(int[] gradesArray) {
					int size = gradesArray.Length;
					double average; 
					int sum = 0;

					for(int i =0; i < size; i++){
						sum += gradesArray[i];
					}
					// double(sum) => casts int as a double
					average = (double)sum / size;
					return average;
				}

				static void getHappiness(int[] happinessArray){
					int size = happinessArray.Length;
					for(int i = 0; i < size; i++){
						happinessArray[i] += 2;
					}

				}

  }
}
