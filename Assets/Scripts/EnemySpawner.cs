using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;

    // smart contract
    // public float stageNumber;

    public Number stageNumber;


    public GameObject currentEnemy;

    public UnityEvent<GameObject> Spawned;


    public TMPro.TMP_Text stageNumberText;

    public void AdvanceStage()
    {
        // stageNumber.Add(1);
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
        stageNumberText.text = stageNumber.Value.ToString();
    }

    public void Spawn()
    {
        var go = Instantiate(myPrefab);
        currentEnemy = go;
        CalculatePercentageIncrease(go.GetComponent<RaycastReceiver>());
        Spawned?.Invoke(go);
    }

    // public float baseHealth = 10f;
    // public float healthRewardExponent = .1f;

    // public float baseReward = 1f;
    // public float rewardExponent = 1.1f;




    // [ContextMenu("Predict")]
    // public void Predict()
    // {
    //     int modifierLength = 100;

    //     for (int i = 0; i < modifierLength; i++)
    //     {
    //         var result = Calculate(baseHealth, healthRewardExponent, i);
    //         Debug.Log(i + ": " + result);
    //     }
    // }

    // public float Calculate(float initialValue, float growthRate, float iterations)
    // {
    //     return initialValue * Mathf.Pow(growthRate, iterations);
    // }

    public LevelDependentValue health;
    public LevelDependentValue gold;

    public void CalculatePercentageIncrease(RaycastReceiver rr)
    {
        // var totalHealth = Calculate(baseHealth, healthRewardExponent, stageNumber.value);

        rr.maxHealth = health.Value;
        rr.currentHealth = health.Value;
        rr.goldAmount = gold.Value;

        // var totalGold = Calculate(baseReward, rewardExponent, stageNumber.value);
    }
}
