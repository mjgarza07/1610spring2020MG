using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumWeapons : MonoBehaviour
{
   public enum WeaponsState
   {
       Shooting,
       Lasoing,
       Punching,
       Bucking
   }

   public WeaponsState currentWeaponsState;
   
   public enum WeaponType
   {
       Gun,
       Rope,
       Brassknuckles,
       Horse
   }
   
        
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
