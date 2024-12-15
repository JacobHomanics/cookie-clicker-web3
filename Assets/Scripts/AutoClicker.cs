using UnityEngine;

public class AutoClicker : MonoBehaviour
{

    public float damage;

    public float cooldown;

    public float timeLeft;



    void Update()
    {

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = cooldown;
            FindAnyObjectByType<EnemySpawner>().currentEnemy.GetComponent<RaycastReceiver>().TakeDamage(damage);
        }
    }
}
