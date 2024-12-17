using UnityEngine;
using UnityEngine.UI;

public class BtnInteractableNumberComparedNumberDependentValue : MonoBehaviour
{
    public Button btn;

    public Number n;

    public NumberDependentValue ndp;

    void Update()
    {
        btn.interactable = n.Value >= ndp.Value;
    }
}
