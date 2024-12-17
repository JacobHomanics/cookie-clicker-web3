public class UpdateMonoBehaviourCallback : BaseMonoBehaviourCallback<Updated>
{
	private void Update()
	{
		Callback?.Invoke(this);
	}
}
