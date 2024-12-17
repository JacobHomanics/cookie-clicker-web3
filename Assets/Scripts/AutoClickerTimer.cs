using UnityEngine;

public class AutoClickerTimer : MonoBehaviour
{
    public AutoClicker autoClicker;

    //smart contract
    public float Duration
    {
        get
        {
            return Calculate(initialTimeLeft, growthRate, level);
        }
    }

    public float Calculate(float initialValue, float growthRate, float iterations)
    {
        return initialValue * Mathf.Pow(growthRate, iterations);
    }


    public float initialTimeLeft = 2.5f;

    public float elapsedTime;

    public float growthRate;
    public float level;

    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = Duration.ToString("F2");
        if (autoClicker.level <= 0)
        {
            return;
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime >= Duration)
        {
            elapsedTime = 0;
            FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(autoClicker.damage);

        }
    }

    public void DecreaseByCurve()
    {
        level++;
    }
}
