using System;

public class Program
{
	public Mech Marauder;
    public Mech Atlas;
    public Mech Wolverine;
    public Mech Locust;
	
	public void Main()
	{
		Marauder = new Mech();
        Atlas = new Mech();
        Wolverine = new Mech();
        Locust = new Mech();

        Marauder.mechName = "Marauder";
        Marauder.mechType = "Heavy";
        Marauder.mechTonnage = 75;

        Atlas.mechName = "Atlas";
        Atlas.mechType = "Assault";
        Atlas.mechTonnage = 100;

        Wolverine.mechName = "Wolverine";
        Wolverine.mechType = "Medium";
        Wolverine.mechTonnage = 55;
        
        Locust.mechName = "Locust";
        Locust.mechType = "Light";
        Locust.mechTonnage = 20;


        Console.WriteLine(Marauder.mechName + " has a mech class of " + Marauder.mechType);
		Console.WriteLine("Its tonnage is " + Marauder.mechTonnage);

        Console.WriteLine(Atlas.mechName + " has a mech class of " + Atlas.mechType);
        Console.WriteLine("Its tonnage is " + Atlas.mechTonnage);

        Console.WriteLine(Wolverine.mechName + " has a mech class of " + Wolverine.mechType);
        Console.WriteLine("Its tonnage is " + Wolverine.mechTonnage);

        Console.WriteLine(Locust.mechName + " has a mech class of " + Locust.mechType);
        Console.WriteLine("Its tonange is " + Locust.mechTonnage);

    
	}
}
public class Mech
{
	public string mechName;
	public string mechType;
	public int mechTonnage;

}