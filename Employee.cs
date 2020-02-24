namespace oopLearn {
    public class Employee {
			protected string FirstName {get; set;}

			protected string LastName {get; set;}

			protected int Salary {get; set;}

			public void Work(){
				System.Console.WriteLine("{0} works from 9 - 5 making {1} a year", this.FirstName, this.Salary);
			}

			public void Pause(){
				System.Console.WriteLine("{0} is taking a break!", this.FirstName);
			}

			public Employee(){

			}

			public Employee(string firstName, string lastName, int salary){
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Salary = salary;
			}
    }
}