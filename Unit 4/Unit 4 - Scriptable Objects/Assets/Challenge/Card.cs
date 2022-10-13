using UnityEngine;

[CreateAssetMenu(fileName = "New Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite artwork;
    public int attack;
    public int health;
    public int speed;

    public void Print() 
    {
        Debug.Log(name + ":" + description);
    }
   
}
