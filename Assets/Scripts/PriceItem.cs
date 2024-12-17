using UnityEngine;

public class PriceItem : MonoBehaviour
{
    public float basePrice;
    public float rewardExponent = 1.1f;

    //smart contract
    public float level;

    public float price
    {
        get
        {
            return Calculate(basePrice, rewardExponent, level);
        }
    }

    public float Calculate(float baseValue, float exponent, float modifier)
    {
        return baseValue * Mathf.Pow(exponent, modifier - 1);
    }


    public TMPro.TMP_Text text;


    void Update()
    {
        text.text = price.ToString("F2") + " coins";
    }

    public void IncreaseByCurve()
    {
        level++;
    }
}
