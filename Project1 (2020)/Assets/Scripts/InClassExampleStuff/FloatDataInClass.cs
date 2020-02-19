
using UnityEngine;
[CreateAssetMenu]
public class FloatDataInClass : ScriptableObject
{
  public float value = 1f;

  public void ChangeValue(float number)
  {
    value += number;
  }
}
