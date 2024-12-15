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
            return basePrice * Mathf.Pow(level, rewardExponent);
        }
    }
    // public float price;
    public TMPro.TMP_Text text;

    // public float percentageIncreasePerUpgrade;

    void Update()
    {
        text.text = price.ToString("F2") + " coins";
    }

    public void IncreaseByCurve()
    {
        level++;
        // price = price + price * (percentageIncreasePerUpgrade / 100);
    }
}
