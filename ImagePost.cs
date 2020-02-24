using System;

namespace oopLearn {
	//inherits from post
	public class ImagePost:Post {
		private string imageURL {get; set;}

		public ImagePost() {

		}

		public ImagePost(string title, string SendByUsername, string imageURL, bool isPublic){
			this.ID = GetNextID();
			this.Title = title;
			this.SendByUsername = SendByUsername;
			this.imageURL = imageURL;
			this.IsPublic = isPublic;
		}

		public override string ToString(){
			return String.Format("{0} - {1} at {2} by {3}", this.ID, this.Title, this.imageURL, this.SendByUsername);
		}

    }
}