using System;
using System.Threading;


namespace oopLearn {
    public class VideoPost:Post {
			//members
			protected int duration {get; set;}
			protected bool isPlaying = false;
			Timer timer;
		
	
			//properties

			protected int Length {get; set;}


			protected string VideoURL {get; set;}

			public VideoPost() {

			}

			public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic) {
				this.ID = GetNextID();
				this.Title = title;
				this.SendByUsername = sendByUsername;
				this.VideoURL = videoURL;
				this.Length = length;
				this.IsPublic = isPublic;
			}

			public override string ToString(){
				return String.Format("{0} - title: {1} url: {2} length: {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
			}

			public void PlayVideo(){

				// timer = new System.Timers.Timer();

				// timer.Interval = 1000;

				// timer.Elapsed += onTimedEvent;

				// timer.Enabled = true;

				if(!isPlaying){
					System.Console.WriteLine("Playing");
					isPlaying = true;
					timer = new Timer(onTimedEvent, null, 0, 1000);
				}
				
			}

			private void onTimedEvent(Object source){
				if(duration <= this.Length){
					duration +=1;
					System.Console.WriteLine("current duration: {0}", duration);
					// clean up
					GC.Collect();
				} else {
					StopVideo();
				}
				
			}

			public void StopVideo(){
				if(isPlaying){
					isPlaying = false;
					System.Console.WriteLine("Stopped at {0}s", duration);
				}
			}

    }
}