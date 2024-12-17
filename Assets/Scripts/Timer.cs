using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [Header("Properties")]
    public float duration;
    public float elapsedTime;

    [Header("Events")]
    public UnityEvent OnTick;
    public UnityEvent OnDurationElapsed;

    public void Tick(float delta)
    {
        elapsedTime += delta;
        OnTick?.Invoke();
    }

    void Update()
    {
        Tick(Time.deltaTime);

        if (elapsedTime >= duration)
        {
            elapsedTime = 0;
            OnDurationElapsed?.Invoke();
        }

    }
}
