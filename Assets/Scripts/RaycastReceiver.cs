using UnityEngine;
using DG.Tweening;

public class RaycastReceiver : MonoBehaviour
{
    public float playerDamagePerClick = 1;

    public float maxHealth = 3;
    public float currentHealth = 3;

    public Animator animator;

    public Outline outline;

    public bool isTargeted = false;

    public GameObject renderObject;

    public float fadeTimeOnDeath = 5f;

    public GameObject[] potentialModels;

    public GameObject activeModel;

    public void OnEnter()
    {
        if (currentHealth <= 0)
            return;

        isTargeted = true;
        outline.OutlineWidth = 2f;
    }

    public void OnExit()
    {
        isTargeted = false;

        outline.OutlineWidth = 0;
    }


    void Start()
    {
        var rn = Random.Range(0, potentialModels.Length);
        for (var i = 0; i < potentialModels.Length; i++)
        {
            if (rn == i)
            {
                activeModel = potentialModels[rn];
                outline = activeModel.GetComponent<Outline>();
            }

            potentialModels[i].SetActive(rn == i);
        }
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
                FindAnyObjectByType<EnemySpawner>().Spawn();
                animator.Play("MeleeWarrior@Death01_A");
                GetComponent<Collider>().enabled = false;
                activeModel.GetComponent<Renderer>().material.DOFade(0.0f, fadeTimeOnDeath).OnComplete(() =>
                {
                    Destroy(this.gameObject);
                });
            }
            else
            {
                animator.Play("1H@TakeDamage01");
            }
        }
    }
}
