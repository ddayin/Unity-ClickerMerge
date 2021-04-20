using UnityEngine;
using UnityEngine.UI;
using WanzyeeStudio;

public class UITop : MonoBehaviour
{
    public static UITop instance
    {
        get { return Singleton<UITop>.instance; }
    }

    public int currentCoin = 0;
    private Text textCoin;

    private void Awake()
    {
        textCoin = transform.Find("Text_Coin").GetComponent<Text>();
        textCoin.text = currentCoin.ToString();
    }

    public void AddCoin(int coinToAdd)
    {
        currentCoin += coinToAdd;
        textCoin.text = currentCoin.ToString();
    }

    public void SetCoin(int coin)
    {
        currentCoin = coin;
        textCoin.text = currentCoin.ToString();
    }
}
