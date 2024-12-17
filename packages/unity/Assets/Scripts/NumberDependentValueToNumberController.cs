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
        Debug.Log(number.Value);
        Debug.Log(numberDependentValue.Value);

        number.Value -= numberDependentValue.Value;
    }
}
