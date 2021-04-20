using UnityEngine;
using WanzyeeStudio;

public class CoinFactory : MonoBehaviour
{
    public static CoinFactory instance
    {
        get { return Singleton<CoinFactory>.instance; }
    }
    
    public GameObject coinPrefab;

    public void Create(Vector3 position)
    {
        GameObject newCoin = Instantiate(coinPrefab, this.transform);
        newCoin.transform.position = position;
    }
}
