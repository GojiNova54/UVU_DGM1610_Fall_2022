using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Ferrari SF90" , "Lamborghini Aventador SVJ" , "McLaren Senna" , "Apollo Emozione Intensa" , "Bugatti Divo" , "Porsche 918"};
		Console.WriteLine(cars.Length);
		foreach(var car in cars) {
			Console.WriteLine(car);
		}
		
		string[] playerTypes = {"Rifleman" , "Rifleman" , "Rifleman"};
		
		for (var i = 0; i < playerTypes.Length ; i++) {
			playerTypes[i] = "Squad Leader";
		}
		
		foreach(var playerType in playerTypes) {
			Console.WriteLine(playerType);
		}
		
		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Alpha AK";
		weaponsObjs[2].weaponName = "AUG A3";
		
		for(var i=0;i<weaponsObjs.Length;i++) {
			weaponsObjs[i].powerLevel = 3;
		}
		
		foreach(var item in weaponsObjs) {
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
	}

public class weapon {
	public string weaponName = "SIG MCX";
	public int powerLevel = 1;
}	
	
}