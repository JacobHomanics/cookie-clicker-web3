using UnityEngine;

public class AutoClicker : MonoBehaviour
{

    public float damage;
    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = damage.ToString();
    }

    public void AddDamage(float amount)
    {
        damage += amount;
    }

    public float percentage;

    public void IncreaseByCurve()
    {
        damage = damage + damage * (percentage / 100);
    }

    // public void IncreaseByCurve() {

    // }
}
