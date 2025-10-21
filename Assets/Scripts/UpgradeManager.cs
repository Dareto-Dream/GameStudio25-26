using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;
    public float Money = 0.0f;
    public float MoneyPerSecond = 1.0f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void addMoney()
    {
        Money += MoneyPerSecond; 
    }

    public void exUpgradeMultiply(ref float multiplier)
    {
        MoneyPerSecond *= multiplier;
    }

    public void exUpgradeAdd(ref float additive)
    {
        MoneyPerSecond += additive;
    }

    public void UpgradeGeneral()
    {
        MoneyPerSecond *= 1.5f;
    }

    public float getMoney()
    {
        return Money;
    }

    public float getMpS()
    {
        return MoneyPerSecond;
    }
}
