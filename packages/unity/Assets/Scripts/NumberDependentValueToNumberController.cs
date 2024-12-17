using UnityEngine;

public class NumberDependentValueToNumberController : MonoBehaviour
{
    public Number number;
    public void Add(NumberDependentValue numberDependentValue)
    {
        number.Value += numberDependentValue.Value;
    }

    public void Subtract(NumberDependentValue numberDependentValue)
    {
        number.Value -= numberDependentValue.Value;
    }

    public float Simulate(NumberDependentValue numberDependentValue)
    {
        return number.Value - numberDependentValue.Value;
    }
}
