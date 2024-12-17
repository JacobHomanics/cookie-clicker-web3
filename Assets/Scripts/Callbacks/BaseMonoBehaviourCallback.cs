using UnityEngine;

public class BaseMonoBehaviourCallback : MonoBehaviour
{

}

public class BaseMonoBehaviourCallback<E> : BaseMonoBehaviourCallback where E : new()
{
    public E Callback = new E();
}

