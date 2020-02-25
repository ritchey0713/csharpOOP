namespace oopLearn {
    public class M3:Bmw {
			public M3(int hp, string color, string model):base(hp, color, model){
				this.Model = model;
			}

				//cannot override if parent method is sealed
				// can also seal an entire class
			// public override void Repair(){
			// 	base.Repair();
			// }
    }
}