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

            for (int i = 0; i < components.Length; i++)
            {
                _value = components[i].Calculate(_value);
            }


            OnChange?.Invoke(_value);
        }
    }

    public UnityEvent<float> OnChange;

    public NumberComponent[] components;

    public void AddOrSubtract(float newValue)
    {
        Value += newValue;
    }

    [ContextMenu("Add 1")]
    public void Add1()
    {
        Value += 1;
    }

    public void Add(Number number)
    {
        Value += number.Value;
    }

    public void Subtract(Number number)
    {
        Value -= number.Value;
    }
}
