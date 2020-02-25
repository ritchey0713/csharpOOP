namespace oopLearn {
    public class Car {
			protected int HP {get; set;}
			protected string Color {get; set;}

			public Car() {

			}

			public Car(int hp, string color){
				this.HP = hp;
				this.Color = color;
			}

			public void ShowDetails(){
				System.Console.WriteLine("car color: {0}, HP: {1}", this.Color, this.HP);
			}

			public void Repair(){
				System.Console.WriteLine("Car repaired!");
			}
        
    }
}