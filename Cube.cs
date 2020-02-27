using System;

namespace oopLearn {
  class Cube:Shape {

		public double Length {get; set;}

		public Cube(double length){
			Name = "Cube";
			Length = length;
		}

		public override double Volume(){
			return Math.Pow(this.Length, 3);
		}

		public override void GetInfo(){
			base.GetInfo();
			System.Console.WriteLine($"the cube has a length of {Length}");
		}
  }
}