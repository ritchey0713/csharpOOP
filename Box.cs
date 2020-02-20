using System;

namespace oopLearn {
	public class Box {
		// member variables
		public int length;
		public int height;
		public int width;
		public int volume;

		public void DisplayInfo() {
			System.Console.WriteLine("Length is {0}, Height is {1}, Width is {2} and volume is {3}",
			 length, height, width, volume = length * height * width);
		}


	}
}