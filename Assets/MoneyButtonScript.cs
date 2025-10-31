using UnityEngine;
using TMPro;

public class MoneyButton : MonoBehaviour
{
    public static int money = 0;
    public TMP_Text moneyText;
    
    private void Start()
    {
        UpdateDisplay();
    }
    
    public void OnButtonClick()
    {
        money += 1;
        UpdateDisplay();
    }
    
    private void UpdateDisplay()
    {
        if (moneyText != null)
        {
            moneyText.text = "$" + money;
        }
    }
}