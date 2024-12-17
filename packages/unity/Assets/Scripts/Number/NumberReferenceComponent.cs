using UnityEngine;

public class NumberReferenceComponent : NumberComponent
{
    public Number number;

    public override float Calculate(float value)
    {
        return number.Value;
    }
}
