namespace oopLearn {
    public class Boss:Employee {
      protected string CompanyCar {get; set;}

			public Boss(string firstName, string lastName, int salary, string companyCar){
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Salary = salary;
				this.CompanyCar = companyCar;
			}

			public void Lead(){
				System.Console.WriteLine("{0} is leading the team!", this.FirstName);
			}
    }
}