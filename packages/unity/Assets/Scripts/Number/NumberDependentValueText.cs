using UnityEngine;
using TMPro;

public class NumberDependentValueText : MonoBehaviour
{
    public NumberDependentValue reference;
    public TMP_Text text;
    public string format;

    void Update()
    {
        text.text = reference.Value.ToString(format);
    }
}
