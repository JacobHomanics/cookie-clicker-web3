using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public Outline lastActiveOutline;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var hitObject = hit.collider.gameObject.GetComponent<Outline>();

            if (hitObject != null)
            {
                if (lastActiveOutline != null)
                {
                    lastActiveOutline.OutlineWidth = 0;
                    lastActiveOutline = null;
                }

                hitObject.OutlineWidth = 2f;
                lastActiveOutline = hitObject;
            }
            else
            {
                if (lastActiveOutline != null)
                {
                    lastActiveOutline.OutlineWidth = 0;
                    lastActiveOutline = null;
                }
            }
        }
        else
        {
            if (lastActiveOutline != null)
            {
                lastActiveOutline.OutlineWidth = 0;
                lastActiveOutline = null;
            }
        }
    }
}
