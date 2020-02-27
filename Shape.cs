namespace oopLearn {
  abstract class Shape {
    public string Name {get; set;}

		public virtual void GetInfo(){
			System.Console.WriteLine($"This is a {Name}");
		}

		// tell deriving classes they much make a Volume method
		public abstract double Volume();
  }
}