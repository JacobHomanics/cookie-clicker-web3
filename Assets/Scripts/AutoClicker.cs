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
}
