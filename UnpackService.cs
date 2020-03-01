
using System;

namespace oopLearn {
    public class UnpackService {
			public void OnFileDownloaded(object source, FileEventArgs e){
				System.Console.WriteLine("Unpacker service, unpacking file..." + e.File.Title);
			}
    }
}