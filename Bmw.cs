namespace oopLearn {
    public class Bmw:Car {
      private string Brand = "Bmw";

			protected string Model {get; set;}

			public Bmw(){

			}
//using base sets up inherited class to use that part of the parent class constructor
			public Bmw(int hp, string color, string model):base(hp, color){
				this.Model = model;
			}

			public override void ShowDetails(){
				System.Console.WriteLine("The awesome {0} {1} has {2} hp and is {3}", this.Brand, this.Model, this.HP, this.Color);
			}

			public void Repair(){
				System.Console.WriteLine("The awesome {0} has been repaired, enjoy your dollar ramen for the rest of the month LOL", this.Model);
			}
    }
}