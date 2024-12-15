using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject lastHitGameObject;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var hitObject = hit.collider.gameObject;


            if (hitObject != null)
            {
                if (lastHitGameObject != null)
                {
                    lastHitGameObject.GetComponent<RaycastReceiver>().OnExit();
                    lastHitGameObject = null;
                }

                hitObject.GetComponent<RaycastReceiver>().OnEnter();
                lastHitGameObject = hitObject;
            }
            else
            {
                if (lastHitGameObject != null)
                {
                    lastHitGameObject.GetComponent<RaycastReceiver>().OnExit();
                    lastHitGameObject = null;
                }
            }
        }
        else
        {
            if (lastHitGameObject != null)
            {
                lastHitGameObject.GetComponent<RaycastReceiver>().OnExit();
                lastHitGameObject = null;
            }
        }
    }
}
