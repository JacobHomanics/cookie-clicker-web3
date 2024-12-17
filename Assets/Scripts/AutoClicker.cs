using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public Level level;

    public float damage
    {
        get
        {
            return Calculate(baseValue, rewardExponent, level.value);
        }
    }
    public float Calculate(float initialValue, float growthRate, float iterations)
    {
        return initialValue * Mathf.Pow(growthRate, iterations);
    }


    //smart contract
    // public float level;

    public float baseValue;
    public float rewardExponent;


    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = damage.ToString("F2");
    }


    // public void IncreaseByCurve()
    // {
    //     level++;
    // }
}
