using UnityEngine;

public class AutoClicker : MonoBehaviour
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
        if (damage == 0)
        {
            damage += 1;
        }
        else
        {
            damage = damage + damage * (percentage / 100);

        }
    }
}
