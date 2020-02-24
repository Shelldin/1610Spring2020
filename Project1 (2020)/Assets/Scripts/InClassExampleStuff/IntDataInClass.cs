using UnityEngine;
[CreateAssetMenu]
public class IntDataInClass : ScriptableObject
{
   public int value = 1;

   public void ChangeValue(int number)
   {
      value += number;
   }
}
