using UnityEngine;
using UnityEngine.UI;

public class BtnInteractableToGoldCount : MonoBehaviour
{

    public GoldCount goldCount;

    public Button btn;


    public PriceItem priceItem;

    void Update()
    {
        // btn.interactable = goldCount.gold.Value >= priceItem.price;
    }
}
