using UnityEngine;

public class GoldCount : MonoBehaviour
{
    public TMPro.TMP_Text text;

    public float amount;

    void Update()
    {
        text.text = amount.ToString();
    }

    public void AddGold(float amount)
    {
        this.amount += amount;
    }

    public void RemoveGold(float amount)
    {
        this.amount = Mathf.Clamp(this.amount - amount, 0, Mathf.Infinity);
    }
}
