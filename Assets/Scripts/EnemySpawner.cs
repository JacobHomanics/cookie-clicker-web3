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

    [ContextMenu("Predict")]
    public void Predict()
    {
        // int exponent = 100;

        // for (int i = 0; i < exponent; i++)
        // {
        //     Debug.Log(totalExp);

        //     // var result = Mathf.Pow(i, healthRewardExponent);
        //     // Debug.Log("For stage number: " + i + ", increase by " + result);
        // }
    }

    public void CalculatePercentageIncrease(RaycastReceiver rr)
    {

        // var totalGoldToAdd = 0f;
        // var totalHealthToAdd = 0f;

        // for (int i = 0; i < stageNumber; i++)
        // {
        //     totalHealthToAdd += Mathf.Pow(stageNumber, healthRewardExponent);
        //     totalGoldToAdd += Mathf.Pow(stageNumber, rewardExponent);


        //     // var totalhealth = baseHealth * Mathf.Pow(stageNumber, healthRewardExponent);
        //     // rr.maxHealth = totalhealth;
        //     // rr.currentHealth = totalhealth;

        //     // var totalReward = baseReward * Mathf.Pow(stageNumber, rewardExponent);
        //     // rr.goldAmount = totalReward;
        // }

        var totalHealth = baseHealth * Mathf.Pow(healthRewardExponent, stageNumber - 1);

        rr.maxHealth = totalHealth;
        rr.currentHealth = totalHealth;

        var totalGold = baseReward * Mathf.Pow(rewardExponent, stageNumber - 1);
        rr.goldAmount = totalGold;

        // rr.currentHealth = totalhealth;

        // var totalReward = baseReward * Mathf.Pow(stageNumber, rewardExponent);
        // rr.goldAmount = totalReward;



    }
}
