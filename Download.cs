using System;
using System.Threading;


namespace oopLearn {

	public class FileEventArgs:EventArgs {
		public File File {get; set;}
	}

  public class Download {

		//define delegate for event 
		// public delegate void FileDownloadedEventHandler(object source, EventArgs args);
		//public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

		// c# built in eventhandler 
		//EventHandler<FileEventArgs>

		// create an event based on delegate
		//public event FileDownloadedEventHandler FileDownloaded;  
		public event EventHandler<FileEventArgs> FileDownloaded;

		
		public void DownloadFile(File file){
			System.Console.WriteLine("downloading...");
			Thread.Sleep(4000);

			// raise event 
			OnFileDownloaded(file);
		}
		
		// raise event
		protected virtual void OnFileDownloaded(File file){
			// check for subscribers to event if something is subscribed, event will not be null, even though it was never assigned a value
			if(FileDownloaded != null){
				// source will point to object calling event, this class 
				FileDownloaded(this, new FileEventArgs() {File = file});
			}
		}
  }


}