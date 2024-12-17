using UnityEngine;
using UnityEngine.UI;

public class BtnInteractableToGoldCount : MonoBehaviour
{
    public Button btn;

    public Number gold;
    public NumberDependentValue price;

    void Update()
    {
        btn.interactable = gold.Value >= price.Value;
    }
}
