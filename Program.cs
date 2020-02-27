using System;
using System.Collections;
using System.Collections.Generic;


namespace oopLearn
{


// enums 
	enum Day {Mon, Tues, Weds, Thur, Fri, Sat, Sun}
	//reassigning emun index
	enum Months {Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec}

// if inheriting from interface you choose what methods HAVE to be included in the inheriting class
// useful when only a small amount of things should be inherited, ie when you shouldnt have a full class to inherit from
// interface = what to do 
// class that inherits, how to do it
	public interface INotifications {
		void showNotification();
		string getDate();
			
	}

	public class Notification:INotifications {
		private string sender;
		private string message;
		private string date;

		public Notification() {
			this.sender = "Admin";
			this.message="Hello!";
			this.date = " ";
		}

		public Notification(string mySender, string myMessage, string myDate){
			this.sender = mySender;
			this.message= myMessage;
			this.date = myDate;
		}

		
		public void showNotification(){
			System.Console.WriteLine("Message {0} sent by {1} at {2}", this.message, this.sender, this.date);
		}
		public string getDate(){
			return this.date;
		}

	}

	//structs 
	// cannot create empty constructor, must set all properties before calling methods
	// cannot have null ref
	// can have interface
	// no inheritance 

		public struct Game {
				public string name; 
				public string developer;
				public double rating; 
				public string releaseDate;

				public Game(string name, string developer, double rating, string releaseDate){
					this.name = name;
					this.developer = developer;
					this.rating = rating;
					this.releaseDate = releaseDate;
				}

				public void Display(){
						System.Console.WriteLine("game name: {0}", this.name);
						System.Console.WriteLine("game dev: {0}", this.developer);
						System.Console.WriteLine("game rating: {0}", this.rating);
						System.Console.WriteLine("game released: {0}", this.releaseDate);
				}
			}

  class Program {
		static void Main(string[] args) {

			Game game1;
			game1.name = "Pokemon";
			game1.developer = "Niantic";
			game1.rating = 4.7;
			game1.releaseDate = "Mar 21 2019";

			game1.Display();

			//enums 
				Day fr = Day.Fri;
				Day su = Day.Sun;

				Day a = Day.Fri;

				System.Console.WriteLine(fr == a);


				System.Console.WriteLine("the day is {0}", Day.Mon);
				System.Console.WriteLine((int)Day.Mon);

				System.Console.WriteLine((int)Months.Aug);
		




			// create a new instance
			// Human jon = new Human("John", "Smith", "Blue", 30);
			// //assign member variable
			// // jon.firstName = "Jon";
			// // jon.lastName = "Smith";
			// //call method duh
			// jon.IntroduceMyself();

			Human michael = new Human("Michael", "Richards", "Brown");

			
			// michael.firstName = "Michael";
			// michael.lastName = "Richards";

			michael.IntroduceMyself();
			michael.findMatches();

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
			// List<int> list = new List<int> {1,2,3,4,5};
			// //adds to end of the list 
			// list.Add(0);
			// list.Add(6);
			// list.Sort();
			// list.RemoveRange(0,2);

			// foreach(int i in list){
			// 	System.Console.WriteLine("Num: {0}", i);
			// }

			// System.Console.WriteLine(list.Contains(4));
			// // find index of element matching expression, ie what index is the num 4 located at
			// int index = list.FindIndex(x => x == 4);
			
			// System.Console.WriteLine(list[index]);

			// list.RemoveAt(index);

			// list.ForEach(i => System.Console.WriteLine(i));

			// //array list 
			// ArrayList arrayList4 = new ArrayList();
			// arrayList4.Add(1);
			// arrayList4.Add(10);
			// arrayList4.Add("3");
			// arrayList4.Add(new Number {n = 4} );

			// foreach(object o in arrayList4){
			// 	System.Console.WriteLine(o);
			// }

			// Post post1 = new Post("New Post", true, "Anon");
			// System.Console.WriteLine(post1.ToString());

			// ImagePost post2 = new ImagePost("Image", "anon", "Image url" ,true );

			// System.Console.WriteLine(post2.ToString());

			// VideoPost post3  = new VideoPost("video", "Youtube", "google.com", 2000, true);
			// //System.Console.WriteLine(post3.ToString());

			// post3.PlayVideo();

			// System.Console.WriteLine("Press any key to pause");
			// string input = Console.ReadLine();
			// post3.StopVideo();
			
			// if (input.ToLower().Equals("play")){
			// 	post3.PlayVideo();
			// }

			//call employee
			Employee employee = new Employee("Derek", "Sims", 20000);
			employee.Work();

			Boss boss = new Boss("Sally", "Sims", 2000000, "Bently" );

			boss.Lead();

			Trainee trainee = new Trainee("Chris", "Cross", 5000, "9-12", "12-8");
			trainee.Work();

			Notification note = new Notification("Denny", "Sup?", DateTime.Now.ToString());
			Notification note2 = new Notification("Sarah", "Hi", DateTime.Now.ToString());

			note.showNotification();
			note2.showNotification();

			// Car car = new Car(300, "black");
			// car.ShowDetails();

			// Audi audi = new Audi(300, "blue", "R8");
			// audi.ShowDetails();

			// Bmw bmw = new Bmw(550, "White", "780i");
			// bmw.ShowDetails();


			// polymorph - use virtual on method in base to allow inherited classes modify the method. 
			// in this list these cars are seen as all Car objs
			// using virtual and override allow us to display different showdetails() below
			var cars = new List<Car> {
				new Car(300, "black"),
				new Audi(300, "blue", "R8"),
				new Bmw(550, "White", "780i")
			};

			foreach(var car in cars){
					car.ShowDetails();
			}

			Car bmw2 = new Bmw(300, "green", "3 series");
			Car audi2 = new Audi(500, "Purple", "r6");
			bmw2.Repair();
			audi2.Repair();

			

			// if you build a new instance by telling its type is the inheriting class no need to override/virutal methods
			Bmw bmw3 = new Bmw(245, "white", "compressor");
			bmw3.Repair();


			// can cast a inherited obj back to its base class
			Car car2 = (Car)bmw3;
			car2.Repair();

			M3 myM3 = new M3(300, "red", "M3");
			myM3.Repair();

			bmw2.SetCarIDInfo(11, "John");
			audi2.SetCarIDInfo(123, "Sally");

			bmw2.GetCarIDInfo();
			audi2.GetCarIDInfo();

			//access mod, private means unable to be used outside the class 
			// public avail everywhere in project 
			// protected avail by class and all classes inheriting from that class

			//internal acessable from own assembly(project)
			// start with most restrictive and relax until the use is available 
			//gives full control over app, via variables and methods

	
			// math class 
			//round up 
			System.Console.WriteLine("Cealing: {0}", Math.Ceiling(15.2));
			System.Console.WriteLine("floor: {0}", Math.Floor(15.3));

			int num1 = 1;
			int num2 = 12;

			System.Console.WriteLine("Lower of nums is {0}", Math.Min(num1, num2));

			System.Console.WriteLine("Higher num is {0}", Math.Max(num1, num2));

			System.Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3,5));

			System.Console.WriteLine("pi is {0}", Math.PI);

			System.Console.WriteLine("square root of 25 is {0}", Math.Sqrt(25));

			System.Console.WriteLine("Absolute val of -1000 is {0}", Math.Abs(-1000));

			System.Console.WriteLine("Cos of 1 is {0}", Math.Cos(1));

			// random class 
			Random dice = new Random();

			int numEyes;

			for(int i = 0; i < 10; i++){
				// next takes in a min and max
				numEyes = dice.Next(1,7);
				System.Console.WriteLine("die roll is {0}", numEyes);
			}

			// fortune teller 
			Random fortuneTeller = new Random();
			int fortune; 

			for(int j = 0; j < 10; j++){
				fortune = fortuneTeller.Next(1,4);
				switch(fortune){
					case 1: 
						System.Console.WriteLine("Yes");
						break;
					case 2: 
						System.Console.WriteLine("No");
						break;
					case 3:
						System.Console.WriteLine("Maybe");
						break;
					default:
						break;
				}
			}	


					Human testMatch = new Human();

							//regex 
		// phone num select 
		//\d{3}[.#-]\d{3}[.#-]\d{4}
		//german numbers 
		// \+\d{5}\/\d{8}|^\d{4}[\/]\d{8}|^\d{7}\/\d{8}

			testMatch.findMatches();

			//date time 
			DateTime dateTime = new DateTime(2018, 4, 9);

			System.Console.WriteLine("My favorite day is {0}", DateTime.Today);

			DateTime tomorrow = GetTomorrow();

			System.Console.WriteLine(GetFirstDayOfYear(1990));
			
			System.Console.WriteLine("tomorrow is {0}", dateTime.DayOfWeek);

			int days = DateTime.DaysInMonth(2000, 2);

			System.Console.WriteLine(days);

			DateTime now = DateTime.Now;

			System.Console.WriteLine("the minute is {0}", now.Minute);

			System.Console.WriteLine("Current time is: {0} o'clock {1} minutes, and {2} seconds", now.Hour, now.Minute, now.Second);

			// System.Console.WriteLine("write the date in this format yyyy-mm-dd");
			// string input = Console.ReadLine();
			// if(DateTime.TryParse(input, out dateTime)){
			// 	System.Console.WriteLine(dateTime);
			// 	TimeSpan daysPassed = now.Subtract(dateTime);
			// 	System.Console.WriteLine("days passed {0}", daysPassed.Days);
			// } else {
			// 	System.Console.WriteLine("wrong format");
			// }

			//nullables 
			int? nullNum = null;
			int? nullNum2 = 1234;

			double? nullDouble = new Double();
			double? nullDouble2 = 1234.4353543;

			bool? isPerson = null;

			if(isPerson == true){
				System.Console.WriteLine("Hello person");
			} else if (isPerson == false){
				System.Console.WriteLine("Are you a robot?");
			} else {
				System.Console.WriteLine("Im not sure what you are");
			}

			double? num20 = 2.6;
			double? num21 = null;
			double num22 = 20.6;

			if(num20 == null){
				num22 = 0.0;
			} else {
				num22 = (double)num20;
			}

			System.Console.WriteLine(num22);
			// null coalescing operator - converts non nullable to nullable if left of ?? is null assigns right side, like ||= in ruby
			num22 = num20 ?? 8.11;

			System.Console.WriteLine(num22);


		// garbage collector auto with .net

		// abstract cant create abstract objs 
	//	Shape shape1 = new Shape();

		Shape[] shapes = {new Sphere(10), new Cube(5)};

		// Sphere sphere = new Sphere(10);

		// sphere.GetInfo();

		foreach(Shape shape in shapes){
			shape.GetInfo();

			// as tries to perform cast, if it cant, it will return null, here cube and sphere are different data types so it wont cast them to each other 
			// is returns a bool, checks data type for what you want it to be 
			Cube iceCube = shape as Cube;
			if(iceCube == null){
				System.Console.WriteLine("this shape is no cube!");
			} 

			if(shape is Cube){
				
				System.Console.WriteLine("now this is a cube!");
			}
		}

		// can cast object type to any other object type
		object cube1 = new Cube(7);

		Cube cube2 = (Cube)cube1;

		System.Console.WriteLine("Has a volume of {0}", cube2.Volume());

		} //</main>


		static DateTime GetTomorrow(){
			return DateTime.Today.AddDays(1);
		}

		static DateTime GetFirstDayOfYear(int year){
			return new DateTime(year, 1,1);
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
