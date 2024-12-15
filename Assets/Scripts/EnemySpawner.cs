using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    // smart contract
    public float stageNumber;

    public TMPro.TMP_Text stageNumberText;

    public void AdvanceStage()
    {
        stageNumber++;
        Destroy(currentEnemy);
        Spawn();
    }

    public GameObject myPrefab;
    public GameObject currentEnemy;

    public UnityEvent<GameObject> Spawned;

    public float percentage;
    public float goldPercentage;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        stageNumberText.text = (stageNumber + 1).ToString();
    }

    public void Spawn()
    {
        var go = Instantiate(myPrefab);
        currentEnemy = go;
        CalculatePercentageIncrease(go.GetComponent<RaycastReceiver>());
        Spawned?.Invoke(go);
    }

    public float baseHealth = 10f;
    public float healthRewardExponent = .1f;

    public float baseReward = 1f;
    public float rewardExponent = 1.1f;

    public void CalculatePercentageIncrease(RaycastReceiver rr)
    {

        // var newHealth = 10 + (stageNumber + stageNumber * (percentage / 100));
        // rr.maxHealth = newHealth;
        // rr.currentHealth = newHealth;


        var totalhealth = baseHealth * Mathf.Pow(stageNumber, healthRewardExponent);
        rr.maxHealth = totalhealth;
        rr.currentHealth = totalhealth;


        var totalReward = baseReward * Mathf.Pow(stageNumber, rewardExponent);
        rr.goldAmount = totalReward;
    }
}
