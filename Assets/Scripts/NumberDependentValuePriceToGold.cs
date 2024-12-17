using UnityEngine;

public class NumberDependentValuePriceToGold : MonoBehaviour
{
    public Number gold;

    public void RemoveGold(PriceItem priceItem)
    {
        gold.Value -= priceItem.price;
    }

}
