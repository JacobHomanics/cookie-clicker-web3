using UnityEngine;

public class AutoClickerTimer : MonoBehaviour
{
    [Header("Core")]
    public Level strengthLevel;

    public LevelDependentValue duration;
    public LevelDependentValue damage;

    public Timer timer;

    [Header("UI")]
    public TMPro.TMP_Text durationText;
    public TMPro.TMP_Text damageText;


    void Update()
    {
        timer.enabled = strengthLevel.value > 0;
        timer.duration = duration.Value;

        damageText.text = damage.Value.ToString("F2");
        durationText.text = duration.Value.ToString("F2");
    }

    public void HitEnemy()
    {
        FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(damage.Value);
    }
}
