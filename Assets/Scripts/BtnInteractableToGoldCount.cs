using UnityEngine;
using UnityEngine.UI;

public class BtnInteractableToGoldCount : MonoBehaviour
{
    public GoldCount goldCount;

    public Button btn;

    public float price;

    void Update()
    {
        btn.interactable = goldCount.amount >= price;

    }
}
