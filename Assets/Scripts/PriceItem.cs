using UnityEngine;

public class PriceItem : MonoBehaviour
{
    public float price;
    public TMPro.TMP_Text text;

    public float percentageIncreasePerUpgrade;

    void Update()
    {
        text.text = price.ToString() + " coins";
    }

    public void IncreaseByCurve()
    {
        price = price + price * (percentageIncreasePerUpgrade / 100);
    }
}
