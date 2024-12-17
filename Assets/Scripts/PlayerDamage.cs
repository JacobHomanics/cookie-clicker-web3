using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage
    {
        get
        {
            return baseValue * Mathf.Pow(level, rewardExponent);
        }
    }

    //smart contract
    public float level;

    public float baseValue;
    public float rewardExponent;

    public TMPro.TMP_Text text;

    void Update()
    {
        text.text = damage.ToString("F2");
    }


    public void IncreaseByCurve()
    {
        level++;
    }


}
