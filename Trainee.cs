namespace oopLearn {
    public class Trainee:Employee {
			private string WorkingHours {get; set;}

			private string SchoolHours {get; set;}

			public Trainee(){

			}

			public Trainee(string firstName, string lastName, int salary, string workingHours, string schoolHours) : base(firstName, lastName, salary){
				this.ID = GetNextID();
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Salary = salary;
				this.WorkingHours = workingHours;
				this.SchoolHours = schoolHours;
			}

			public void Learn(){
				System.Console.WriteLine("{0} school hours are {1}", this.FirstName, this.WorkingHours);
			}

			public void Work(){
				System.Console.WriteLine("{0} working hours are {1}", this.FirstName, this.WorkingHours);
			}

    }
}