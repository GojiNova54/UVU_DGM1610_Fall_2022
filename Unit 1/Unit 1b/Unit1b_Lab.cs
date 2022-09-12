using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome back Mechwarrior");
		myOperator.DoMath(052,4);
		myOperator.DoMath(074,2);
		myOperator.DoMath(090,9);
		myOperator.Compare(120,210);
		myOperator.Compare(210,120);
		myOperator.CheckPassword("FedCom3040");
		myOperator.CheckPassword("Cappellan39");
	}
	
	
}

public class Operations {
	public void DoMath (int value, int value2) {
		
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, first is greater.");
			} else {
				Console.WriteLine("False, second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "FedCom3040") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");		
		}
	}

}