using UnityEngine;

public class AutoClickerTimer : MonoBehaviour
{
    public AutoClicker autoClicker;

    //smart contract
    public float cooldown;

    public float timeLeft;

    public float percentage;

    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = cooldown.ToString("F2");
        if (autoClicker.damage <= 0)
        {
            return;
        }

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = cooldown;
            FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(autoClicker.damage);
        }
    }

    public void DecreaseByCurve()
    {
        cooldown = cooldown - cooldown * (percentage / 100);
    }
}
