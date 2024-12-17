using UnityEngine;

public class AutoClickerTimer : MonoBehaviour
{
    public AutoClicker autoClicker;

    public Level level;

    public float Duration
    {
        get
        {
            return Calculate(initialTimeLeft, growthRate, level.value);
        }
    }

    public float Calculate(float initialValue, float growthRate, float iterations)
    {
        return initialValue * Mathf.Pow(growthRate, iterations);
    }


    public float initialTimeLeft = 2.5f;

    // public float elapsedTime;

    public float growthRate;
    // public float level;

    public TMPro.TMP_Text text;

    public MonoBehaviour monoBehaviour;

    void Update()
    {
        text.text = Duration.ToString("F2");
        // if (autoClicker.level.value <= 0)
        // {
        //     return;
        // }

        monoBehaviour.enabled = autoClicker.level.value > 0;

        // elapsedTime += Time.deltaTime;

        // if (elapsedTime >= Duration)
        // {
        //     elapsedTime = 0;
        //     

        // }
    }

    public void HitEnemy()
    {
        FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(autoClicker.damage);
    }

    // public void DecreaseByCurve()
    // {
    //     level++;
    // }
}
