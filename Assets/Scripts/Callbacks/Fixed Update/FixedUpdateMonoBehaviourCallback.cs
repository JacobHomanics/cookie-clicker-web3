public class FixedUpdateMonoBehaviourCallback : BaseMonoBehaviourCallback<FixedUpdated>
{
	private void FixedUpdate()
	{
		Callback?.Invoke(this);
	}
}
