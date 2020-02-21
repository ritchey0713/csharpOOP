namespace oopLearn {
    public class Members {
			// private member / field 
			private string memberName;
			private string jobtitle;

			//public member/ field 
			public int age;

			public string JobTitle {
				get{
					return this.jobtitle;
				}
				set{
					this.jobtitle = value;
				}
			}
    }
}