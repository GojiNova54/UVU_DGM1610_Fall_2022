using System;
					
public class Program
{
	public GameStates gameStates;
	
	public Operations myOperator;
	
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.Starting;
		gameStates.CheckState();
		
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

public class GameStates {

	public enum States {
		Starting,
		Playing,
		Ending,
	}

	public States currentState = States.Starting;

	public void CheckState () {
		switch (currentState) {
			case States.Starting:
				Console.WriteLine("Starting");
				break;
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
		
		}
}}

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