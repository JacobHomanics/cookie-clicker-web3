using UnityEngine;

public class AutoClickerTimer : MonoBehaviour
{
    public AutoClicker autoClicker;

    public Level level;

    public LevelDependentValue duration;

    // public float Duration
    // {
    //     get
    //     {
    //         return Calculate(initialTimeLeft, growthRate, level.value);
    //     }
    // }

    // public float Calculate(float initialValue, float growthRate, float iterations)
    // {
    //     return initialValue * Mathf.Pow(growthRate, iterations);
    // }


    // public float initialTimeLeft = 2.5f;

    // public float growthRate;

    public TMPro.TMP_Text text;

    public Timer timer;

    void Update()
    {
        text.text = duration.Value.ToString("F2");
        timer.enabled = autoClicker.level.value > 0;
        timer.duration = duration.Value;
    }

    public void HitEnemy()
    {
        FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(autoClicker.damage);
    }
}
