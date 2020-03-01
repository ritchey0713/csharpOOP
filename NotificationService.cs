using System;

namespace oopLearn {
    public class NotificationService {
			public void OnFileDownloaded(object source, EventArgs e) {
				System.Console.WriteLine("New notification");
			}
    }
}