using UnityEngine;

public class PriceItem : MonoBehaviour
{
    //smart contract
    public float price;
    public TMPro.TMP_Text text;

    public float percentageIncreasePerUpgrade;

    void Update()
    {
        text.text = price.ToString("F2") + " coins";
    }

    public void IncreaseByCurve()
    {
        price = price + price * (percentageIncreasePerUpgrade / 100);
    }
}
