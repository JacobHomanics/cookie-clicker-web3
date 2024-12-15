using UnityEngine;

public class PriceItem : MonoBehaviour
{
    public float price;
    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = price.ToString() + "coins";
    }
}
