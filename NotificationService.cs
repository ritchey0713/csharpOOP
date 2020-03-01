using System;

namespace oopLearn {
    public class NotificationService {
			public void OnFileDownloaded(object source, FileEventArgs e) {
				System.Console.WriteLine("New notification" + e.File.Title);
			}
    }
}