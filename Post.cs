using System;


namespace oopLearn {
    public class Post {
			private static int currentPostId;
			private string title;

			// properties

			//protected can only be used by their class, and classes that inherit from them
			protected int ID{get; set;}
			protected string Title {
				get{
					return this.title;
				}
				set {
					if(value.Length > 0){
						this.title = value;
					} else {
						throw new Exception("title must be longer than that!");
					}
				}
			}

			protected string SendByUsername { get; set;}

			protected bool IsPublic {get; set;}

			//constructors
			public Post() {
				ID = 0;
				Title = "First Post";
				IsPublic = true;
				SendByUsername = "Jon Smith";
			}

			//defaulkt contructor, if no constructor is called with inherited calss this is called implicittly 
			public Post(string title, bool isPublic, string sendByUsername) {
				this.ID = GetNextID();
				this.Title = title;
				this.IsPublic = isPublic;
				this.SendByUsername = sendByUsername;
			}

			protected int GetNextID(){
				return ++currentPostId;
			}

			public void Update(string title, bool isPublic){
				this.Title = title;
				this.IsPublic = isPublic;
			}

			public override string ToString() {
				// return base.ToString();
				return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
			}



    }


}