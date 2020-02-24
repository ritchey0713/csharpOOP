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

    }
}