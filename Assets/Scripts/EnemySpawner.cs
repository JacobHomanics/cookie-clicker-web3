using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject currentEnemy;

    public UnityEvent<GameObject> Spawned;

    public void Spawn()
    {
        var go = Instantiate(myPrefab);
        currentEnemy = go;
        Spawned?.Invoke(go);
    }
}
