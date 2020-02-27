using System;
using System.Text.RegularExpressions;

namespace oopLearn
{
	public class Human {
		//member variable
		private string firstName;
		private string lastName;
		private string eyeColor;
		private int age;

		//default constructor
		public Human(){

		}

				//paramaterized constructor
		public Human(string firstName, string lastName, string eyeColor) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.eyeColor = eyeColor;
		}

			public Human(string firstName, string lastName) {
			this.firstName = firstName;
			this.lastName = lastName;
		}

			public Human(string firstName) {
			this.firstName = firstName;
		}

		//paramaterized constructor
		public Human(string firstName, string lastName, string eyeColor, int age) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.eyeColor = eyeColor;
			this.age = age;
		}

					public void findMatches(){
				string pattern = @"\d";
				Regex regex = new Regex(pattern);

				string text = "Hi there my num is 123123123";

				MatchCollection matchCollection = regex.Matches(text);

				System.Console.WriteLine("Hits found {0} \n {1}", matchCollection.Count, text);
			}

	

		//default assignment
		//public string name = "Jon";

		// when private cant be changed from other places
		//private string name = "Anon";

		//member method
		public void IntroduceMyself(){
			if(age > 2){
				System.Console.WriteLine("Hi my name is {0} {1} I have {2} eyes, and am {3} years old", firstName, lastName, eyeColor, age);
			} else if (eyeColor != null) {
				System.Console.WriteLine("Hi my name is {0} {1} i have {2} eyes", firstName, lastName, eyeColor);
			} else if( lastName != null) {
				System.Console.WriteLine("Hi my name is {0} {1}", firstName, lastName);
			}	else if (firstName != null) {
					System.Console.WriteLine("Hey my name is {0}", firstName);
				}
			 else {
				System.Console.WriteLine("No info given");
			}
		}
	}
}