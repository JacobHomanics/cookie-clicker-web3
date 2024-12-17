using UnityEngine;
using UnityEngine.Events;

public class NumberCalculator : MonoBehaviour
{
    public NumberComponent[] components;

    public UnityEvent<float> OnCalculate;

    public void Calculate()
    {
        float num = 0f;

        for (int i = 0; i < components.Length; i++)
        {
            num = components[i].Calculate(num);
        }

        OnCalculate?.Invoke(num);
    }
}
