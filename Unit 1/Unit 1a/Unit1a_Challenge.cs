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



        Console.WriteLine(Marauder.mechName + " has a mech class of " + Marauder.mechType);
		Console.WriteLine("Its tonnage is " + Marauder.mechTonnage);

        Console.WriteLine(Atlas.mechName + " has a mech class of " + Atlas.mechType);
        Console.WriteLine("Its tonnage is " + Atlas.mechTonnage);

    
	}
}
public class Mech
{
	public string mechName;
	public string mechType;
	public int mechTonnage;

}