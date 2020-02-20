using System;

namespace oopLearn
{
	public class Human {
		//member variable
		private string firstName;
		private string lastName;

		//constructor
		public Human(string firstName, string lastName) {
			this.firstName = firstName;
			this.lastName = lastName;
		}

		//default assignment
		//public string name = "Jon";

		// when private cant be changed from other places
		//private string name = "Anon";

		//member method
		public void IntroduceMyself(){
			System.Console.WriteLine("Hi my name is {0} {1}", firstName, lastName);
		}
	}
}