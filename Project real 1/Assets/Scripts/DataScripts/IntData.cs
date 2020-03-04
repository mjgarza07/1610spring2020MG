

using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

   public void ChangeValue(int amount)
    {
        value += amount;
    }
    
}


