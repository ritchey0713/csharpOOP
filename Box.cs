using System;

namespace oopLearn {
	public class Box {
		// member variables
		private int length;
		private int height;
		private int width;
		private int volume;

		//properties getters/setters if private only way another file can use it is if it inherits the box class
		private void SetLength(int length) {
			this.length = length;
		}

		public int GetLength() {
			return this.length;
		}

		public int GetVolume(){
			return this.length * this.height * this.width;
		}

		public void DisplayInfo() {
			System.Console.WriteLine("Length is {0}, Height is {1}, Width is {2} and volume is {3}",
			 length, height, width, volume = length * height * width);
		}


	}
}