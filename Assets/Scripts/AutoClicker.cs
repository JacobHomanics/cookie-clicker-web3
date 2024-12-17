using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    [Header("References")]
    public Number strengthLevel;

    public NumberDependentValue duration;
    public NumberDependentValue damage;

    public Timer timer;


    void Update()
    {
        timer.enabled = strengthLevel.Value > 0;
        timer.duration = duration.Value;
    }

    public void HitEnemy()
    {
        FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(damage.Value);
    }
}
