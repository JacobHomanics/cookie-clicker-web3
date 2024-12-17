using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage
    {
        get
        {
            return Calculate(baseValue, rewardExponent, level);
        }
    }

    public float Calculate(float baseValue, float exponent, float modifier)
    {
        return baseValue * Mathf.Pow(exponent, modifier - 1);
    }


    //smart contract
    public float level;

    public float baseValue;
    public float rewardExponent;

    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = damage.ToString("F2");
    }


    public void IncreaseByCurve()
    {
        level++;
    }


}
