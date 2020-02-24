namespace oopLearn {
    public class Boss:Employee {
      protected string CompanyCar {get; set;}

			public void Lead(){
				System.Console.WriteLine("{0} is leading the team!", this.FirstName);
			}
    }
}