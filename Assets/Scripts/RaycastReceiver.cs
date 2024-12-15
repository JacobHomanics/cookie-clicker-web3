using UnityEngine;

public class RaycastReceiver : MonoBehaviour
{
    public float playerDamagePerClick = 1;

    public float maxHealth = 3;
    public float currentHealth = 3;

    public Animator animator;

    public Outline outline;

    public bool isTargeted = false;

    public void OnEnter()
    {
        isTargeted = true;
        outline.OutlineWidth = 2f;
    }

    public void OnExit()
    {
        isTargeted = false;

        outline.OutlineWidth = 0;
    }

    void Update()
    {
        if (!isTargeted) return;

        bool isClicked = false;

        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isClicked = true;
            }
        }


        if (isClicked)
        {
            currentHealth -= playerDamagePerClick;

            if (currentHealth <= 0)
            {
                animator.Play("MeleeWarrior@Death01_A");
            }
            else
            {
                animator.Play("1H@TakeDamage01");
            }
        }
    }
}
