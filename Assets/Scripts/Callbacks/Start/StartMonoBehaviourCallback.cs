using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMonoBehaviourCallback : BaseMonoBehaviourCallback<Started>
{
	private void Start()
	{
		Callback?.Invoke(this);
	}
}
