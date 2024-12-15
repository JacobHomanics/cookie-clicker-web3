using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myPrefab;

    public UnityEvent<GameObject> Spawned;

    public void Spawn()
    {
        var go = Instantiate(myPrefab);
        Spawned?.Invoke(go);
    }
}
