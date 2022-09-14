using System;
					
public class Program 
{

	public ReactorState reactorState;
	
	public SensorsState sensorsState;
	
	public WeaponsState weaponsState;
	
	public Operations myOperator;
	
	public void Main() 
	{
		myOperator = new Operations ();
		
	myOperator.CheckPassword("ComGuard3052");
		
		reactorState = new ReactorState ();
		reactorState.currentState = ReactorState.State.Online;
		reactorState.CheckState();
		
		sensorsState = new SensorsState ();
		sensorsState.currentState = SensorsState.State.Online;
		sensorsState.CheckState();
		
		weaponsState = new WeaponsState ();
		weaponsState.currentState = WeaponsState.State.Online;
		weaponsState.CheckState();
		
		myOperator.CheckStates("Reactor Online, Sensors Online, Weapons Online");
	
	
	}
		
}

public class ReactorState {

	public enum State {
		Online,
		Offline
	}
	
	public State currentState = State.Online;
	
	public void CheckState () {
		switch (currentState) {
			case State.Online:
				Console.WriteLine("Reactor Online");
				break;
			case State.Offline:
				Console.WriteLine("Reactor Offline");
			break;
			
		}
	}
	


}

public class SensorsState {

	public enum State {
		Online,
		Offline
	}
	
	public State currentState = State.Online;
	
	public void CheckState () {
		switch (currentState) {
			case State.Online:
				Console.WriteLine("Sensors Online");
				break;
			case State.Offline:
				Console.WriteLine("Sensors Offline");
			break;
			
		}
	}
	

}

public class WeaponsState {

	public enum State {
		Online,
		Offline
	}
	
	public State currentState = State.Online;
	
	public void CheckState () {
		switch (currentState) {
			case State.Online:
				Console.WriteLine("Weapons Online");
				break;
			case State.Offline:
				Console.WriteLine("Weapons Offline");
			break;
			
		}
	}
	


}



public class Operations {

	public void CheckPassword (string password) {
		if (password == "ComGuard3052") {
			Console.WriteLine("Access Granted, Welcome Back Mechwarrior");
		} else {
			Console.WriteLine("Access Denied");
		}
	}
	
	public void CheckStates (string states) {
		if(states == "Reactor Online, Sensors Online, Weapons Online") {
			Console.WriteLine("All Systems Nominal");
		} else {
			Console.WriteLine("All Systems Offline");
		}
	}

}