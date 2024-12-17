using UnityEngine;

public class Level : MonoBehaviour
{
    public float value;

    public void Add(float amount)
    {
        value += amount;
    }
}
