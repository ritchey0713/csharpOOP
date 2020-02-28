using System;
using System.Threading;


namespace oopLearn {
  public class Download {

		//define delegate for event 
		public delegate void FileDownloadedEventHandler(object source, EventArgs args);
		// create an event based on delegate  
		public event FileDownloadedEventHandler FileDownloaded;

		// raise event
		protected virtual void OnFileDownloaded(){
			if(FileDownloaded != null){

			}
		}
		
		public void DownloadFile(File file){
			System.Console.WriteLine("downloading...");
			Thread.Sleep(4000);
		}
  }
}