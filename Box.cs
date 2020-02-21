using System;

namespace oopLearn {
	public class Box {
		// member variables
		private int length;
		private int height;
		// private int width;
		private int volume;

//property
		public int Height {
			get{
				return this.height;
			}
			set {
				if(value < 0) {
					throw new Exception("Height cant be less than 0");
				} else {
					this.height = value;

				}
			}
		}

		public int Length {
			get{
				return this.length;
			}
			set {
				if(value < 0) {
					throw new Exception("Length must be greater than 0");
				} else {
					this.length = value;
				}
			}
		}

		//read only property 
		public int FrontSurface {
			get {
				return this.length * this.height;
			}
		}

// using prop snippet default property
		public int Width { get; set; }

		public int Volume {
			get {
				return this.Height * this.Width * this.Length;
			}
			// set {
			// 	// this.volume = this.Height * this.Width * this.Length;
			// 	this.volume = value; 
			// }
		}

		public Box(int length, int height, int width){
			this.length = length;
			this.height = height;
			// uppercase since we didnt define it as a member
			this.Width = width;
		}

		// //properties getters/setters if private only way another file can use it is if it inherits the box class
		// public void SetLength(int length) {
		// 	if(length < 1){
		// 		throw new Exception("Length cant be less than 1");
		// 	}
		// 	this.length = length;
		// }

		// public int GetLength() {
		// 	return this.length;
		// }

		public int GetVolume(){
			return this.Length * this.Height * this.Width;
		}

		public void DisplayInfo() {
			System.Console.WriteLine("Length is {0}, Height is {1}, Width is {2} and volume is {3}",
			 length, height, Width, volume = length * height * Width);
		}


	}
}