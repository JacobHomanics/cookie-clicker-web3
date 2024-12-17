using UnityEngine;

public class LevelDependentValue : MonoBehaviour
{
    [Header("Properties")]
    public float initialValue = 1f;
    public float percentageChange = 10f;
    [Header("References")]
    public Level level;

    public float Value
    {
        get
        {
            return Calculate(initialValue, percentageChange, level.value);
        }
    }

    public float Calculate(float initialValue, float percentageChange, float iterations)
    {
        float changeRate = 1 + (percentageChange / 100);
        return initialValue * Mathf.Pow(changeRate, iterations);
    }
}
