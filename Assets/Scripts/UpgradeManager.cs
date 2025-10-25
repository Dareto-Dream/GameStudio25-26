using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;
    public int Money = 0;
    public int MoneyPerSecond = 1;

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

    public void exUpgradeMultiply(ref int multiplier)
    {
        MoneyPerSecond *= multiplier;
    }

    public void exUpgradeAdd(ref int additive)
    {
        MoneyPerSecond += additive;
    }

    public void UpgradeGeneral()
    {
        MoneyPerSecond *= 2;
    }

    public float getMoney()
    //Can you just write a comment for what this does? -Conner
    {
        return Money;
    }

    public float getMpS()
        //Can you just write a comment for what this does? -Conner
    {
        return MoneyPerSecond;
    }
}
