using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;

    public Number stageNumber;

    public GameObject currentEnemy;

    public UnityEvent<GameObject> Spawned;


    public void AdvanceStage()
    {
        Destroy(currentEnemy);
        Spawn();
    }


    void Start()
    {
        Debug.Log("Hello");
        Spawn();
    }



    public void Spawn()
    {
        var go = Instantiate(myPrefab);
        currentEnemy = go;
        CalculatePercentageIncrease(go.GetComponent<RaycastReceiver>());
        Spawned?.Invoke(go);
    }

    public NumberDependentValue health;
    public NumberDependentValue gold;

    public void CalculatePercentageIncrease(RaycastReceiver rr)
    {
        rr.maxHealth = health.Value;
        rr.currentHealth = health.Value;
        rr.goldAmount = gold.Value;
    }
}
