using System;
using System.Threading;


namespace oopLearn {
  public class Download {
		public void DownloadFile(File file){
			System.Console.WriteLine("downloading...");
			Thread.Sleep(4000);
		}
  }
}