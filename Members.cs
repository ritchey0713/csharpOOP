using System.Diagnostics;

namespace oopLearn {
    public class Members {
			// private member / field 
			private string memberName;
			private string jobtitle;
			private int salary = 60000;

			//public member/ field 
			public int age;

		//exposes job title private member
			public string JobTitle {
				get{
					return this.jobtitle;
				}
				set{
					this.jobtitle = value;
				}
			}
			// public member method can be called from any class
			public void Introducing(bool isFriend) {
				if(isFriend) {
					SharingPrivateInfo();
				} else {
					System.Console.WriteLine("Hi my name is {0}, I am a {1}", this.memberName, this.jobtitle);
				}
			}

			private void SharingPrivateInfo(){
				System.Console.WriteLine("My Salary is {0}", this.salary);
			}

			// constructor 
			public Members() {
				age = 30;
				memberName = "Sally";
				salary = 75000;
				jobtitle = "Developer";
				System.Console.WriteLine("Member created!");
			}

			//finalizer/ destructor can only have one
			~Members(){
				// clean up statements 
				System.Console.WriteLine("Deconstruction of member complete");
				// Debug.Write("Deconstruction of member complete");
			}

    }
}