
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public abstract class IntData : ScriptableObject

{
   public int value = 1;

   public void ChangeValue(int number)
   {
      value += number;
   }

}   
