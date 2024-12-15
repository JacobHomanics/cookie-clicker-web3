using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    //smart contract
    public float damage;
    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = damage.ToString("F2");
    }

    public float percentage;

    public void IncreaseByCurve()
    {
        damage = damage + damage * (percentage / 100);
    }
}
