using UnityEngine;

public class Level : MonoBehaviour
{
    public float value;

    public void Add(float amount)
    {
        value += amount;
    }

    [ContextMenu("Add 1")]
    public void Add1()
    {
        value += 1;
    }
}
