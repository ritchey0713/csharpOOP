namespace oopLearn {
    public class Car {
			protected int HP {get; set;}
			protected string Color {get; set;}

			// set up has a relationship 
			protected CarIDInfo carIDInfo = new CarIDInfo();

			public void SetCarIDInfo(int idNum, string owner){
				carIDInfo.IDNum = idNum;
				carIDInfo.Owner = owner;
			}

			public void GetCarIDInfo(){
				System.Console.WriteLine("Car has an ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
			}

			public Car() {

			}

			public Car(int hp, string color){
				this.HP = hp;
				this.Color = color;
			}

			public virtual void ShowDetails(){
				System.Console.WriteLine("car color: {0}, HP: {1}", this.Color, this.HP);
			}

			public virtual void Repair(){
				System.Console.WriteLine("Car repaired!");
			}
        
    }
}