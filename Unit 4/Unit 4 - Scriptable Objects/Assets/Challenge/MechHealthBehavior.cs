using UnityEngine;

public class MechHealthBehavior : MonoBehaviour
{
    public FloatVar mechHealth;
    public void Start()
    {
        mechHealth.value = 100;
    }

   
}
