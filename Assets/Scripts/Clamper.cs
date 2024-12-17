using UnityEngine;

public class Clamper : NumberComponent
{
    public float min = 0;
    public float max = Mathf.Infinity;


    public override float Calculate(float value)
    {
        return Mathf.Clamp(value, min, max);
    }
}
