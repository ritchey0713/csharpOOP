using System;
using System.Threading;


namespace oopLearn {
  public class Download {

		//define delegate for event 
		public delegate void FileDownloadedEventHandler(object source, EventArgs args);

		//define event 
		public void DownloadFile(File file){
			System.Console.WriteLine("downloading...");
			Thread.Sleep(4000);
		}
  }
}