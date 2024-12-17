using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;

    // smart contract
    public float stageNumber;

    public GameObject currentEnemy;

    public UnityEvent<GameObject> Spawned;


    public TMPro.TMP_Text stageNumberText;

    public void AdvanceStage()
    {
        stageNumber++;
        Destroy(currentEnemy);
        Spawn();
    }


    void Start()
    {
        Debug.Log("Hello");
        Spawn();
    }

    void Update()
    {
        stageNumberText.text = stageNumber.ToString();
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

        var totalhealth = baseHealth * Mathf.Pow(stageNumber, healthRewardExponent);
        rr.maxHealth = totalhealth;
        rr.currentHealth = totalhealth;

        var totalReward = baseReward * Mathf.Pow(stageNumber, rewardExponent);
        rr.goldAmount = totalReward;
    }
}
