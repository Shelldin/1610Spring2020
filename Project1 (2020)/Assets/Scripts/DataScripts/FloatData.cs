using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f,
        minValue = 0f,
        maxValue = 1f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void IncreaseValue(float amount)
    {
        if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
    }

    public void DecreaseValue(float amount)
    {
        if (value >= minValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = minValue;
        }


    }
}
