using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome Back Mechwarrior");
		Console.WriteLine("Following Mech types are listed with their tonnage:");
		
		string[] mechTypes = {"Light (20-35 tons)" , "Medium (40-55 tons)" , "Heavy (60-75 tons)" , "Assault (80-100 tons)"};
		foreach(var mechType in mechTypes) {
			Console.WriteLine(mechType);
		}
		
		Console.WriteLine("Following BattleMechs are available for deployment:");
			
		string[] mechs = {"Mercury (20)" , "Mongoose (25)" , "Phoenix Hawk (45)" , "Kintaro (55)" , "Champion (60)" , "Black Knight (75)" , "Nighstar (95)" , "King Crab (100)"};
		Console.WriteLine(mechs.Length);
		foreach(var mech in mechs) {
			Console.WriteLine(mech);
		}
		
		Console.WriteLine("Following primary weapons have been enhanced and are available for deployment:");

		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon(), new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Extended Range Particle Projectile Cannon (ER PPC)";
		weaponsObjs[2].weaponName = "Ultra Auto Cannon 20";
		weaponsObjs[3].weaponName = "Plasma Rifle";
		weaponsObjs[4].weaponName = "Large Pulse Laser";
		
		for(var i=0;i<weaponsObjs.Length;i++) {
			weaponsObjs[i].weaponDamage = 30;
		}
		
		foreach(var item in weaponsObjs) {
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.weaponDamage);
		}
		
		
		
	}

public class weapon {
	public string weaponName = "Gauss Rifle";
	public int weaponDamage = 15;
}
	
}