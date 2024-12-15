using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;

    public void Spawn()
    {
        Instantiate(myPrefab);
    }
}
