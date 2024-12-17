using UnityEngine;
using UnityEngine.Events;

public class Number : MonoBehaviour
{
    [SerializeField] private float _value;
    public float Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
            OnChange?.Invoke(_value);
        }
    }

    public UnityEvent<float> OnChange;

    public void AddOrSubtract(float newValue)
    {
        Value += newValue;
    }

    [ContextMenu("Add 1")]
    public void Add1()
    {
        Value += 1;
    }
}
