
using System;

namespace oopLearn {
    public class UnpackService {
			public void OnFileDownloaded(object source, EventArgs e){
				System.Console.WriteLine("Unpacker service, unpacking file...");
			}
    }
}