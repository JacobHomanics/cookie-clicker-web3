using TMPro;
using UnityEngine;

public class FloatTextDisplayer : MonoBehaviour
{
    public TMP_Text text;

    public string format;

    public void Set(float value)
    {
        text.text = value.ToString(format);

    }
}
