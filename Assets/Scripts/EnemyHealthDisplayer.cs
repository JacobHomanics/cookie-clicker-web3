using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealthDisplayer : MonoBehaviour
{
    public GameObject enemy;

    public TMP_Text maxHealthText;
    public TMP_Text currentHealthText;


    public Slider slider;

    public void SetGameObject(GameObject go)
    {
        enemy = go;
    }

    void Update()
    {
        var rr = enemy.GetComponent<RaycastReceiver>();

        slider.value = rr.currentHealth;
        slider.maxValue = rr.maxHealth;

        currentHealthText.text = rr.currentHealth.ToString("F2");
        maxHealthText.text = rr.maxHealth.ToString("F2");
    }
}
