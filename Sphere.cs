using System;

namespace oopLearn {
    class Sphere:Shape {
			public double radius {get; set;}

			public Sphere(double radius){
				Name = "Sphere";
				this.radius = radius;
			}

			public override double Volume(){
				//return (((4/3) * Math.PI)*(Math.Pow(this.radius,3)));
				double rad = Math.Pow(this.radius, 3);
				double newPi = (double)4/3 * Math.PI;
				return newPi * rad;
			}

			public override void GetInfo(){
				base.GetInfo();
				System.Console.WriteLine("The volume of the sphere is {0}", this.Volume());
			}
    }
}