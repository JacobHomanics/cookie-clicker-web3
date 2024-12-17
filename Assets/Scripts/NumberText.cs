using UnityEngine;
using TMPro;

public class NumberDependent : MonoBehaviour
{
    public Number reference;
    public TMP_Text text;
    public string format;

    void Update()
    {
        text.text = reference.Value.ToString(format);
    }
}
