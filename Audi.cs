namespace oopLearn{
    public class Audi:Car {
			private string Brand = "Audi";
			protected string Model {get; set;}
			public Audi(){

			}
//using base sets up inherited class to use that part of the parent class constructor
			public Audi(int hp, string color, string model):base(hp, color){
				this.Model = model;
			}

			public void ShowDetails(){
				System.Console.WriteLine("The {0} {1} has {2} hp and is {3}", this.Brand, this.Model, this.HP, this.Color);
			}

			public void Repair(){
				System.Console.WriteLine("The {0} is repaired! ouch..", this.Model);
			}
    }
}