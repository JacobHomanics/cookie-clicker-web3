using UnityEngine;

public class DependentValueComponent : NumberComponent
{
    public float initialValue = 1f;
    public float percentageChange = 10f;

    public Number level;

    public override float Calculate(float value)
    {
        return Calculate(initialValue, percentageChange, level.Value);
    }

    public float Calculate(float initialValue, float percentageChange, float iterations)
    {
        float changeRate = 1 + (percentageChange / 100);
        return initialValue * Mathf.Pow(changeRate, iterations);
    }


}
