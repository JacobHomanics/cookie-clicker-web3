using UnityEngine;

public class Adder : NumberComponent
{
    public float number;

    public override float Calculate(float value)
    {
        return value + number;
    }
}
