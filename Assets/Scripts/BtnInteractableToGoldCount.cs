using UnityEngine;
using UnityEngine.UI;

public class BtnInteractableToGoldCount : MonoBehaviour
{

    // public GoldCount goldCount;

    public Button btn;


    // public PriceItem priceItem;


    public Number gold;
    public NumberDependentValue price;

    void Update()
    {
        btn.interactable = gold.Value >= price.Value;

        // btn.interactable = goldCount.gold.Value >= priceItem.price;
    }
}
