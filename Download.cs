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
			// check for subscribers to event if something is subscribed, event will not be null, even though it was never assigned a value
			if(FileDownloaded != null){
				FileDownloaded(this, EventArgs.Empty);
			}
		}
		
		public void DownloadFile(File file){
			System.Console.WriteLine("downloading...");
			Thread.Sleep(4000);

			// raise event 
			OnFileDownloaded();
		}
  }


}