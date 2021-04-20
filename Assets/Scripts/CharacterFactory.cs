using UnityEngine;
using WanzyeeStudio;

public class CharacterFactory : MonoBehaviour
{
    public static CharacterFactory instance
    {
        get { return Singleton<CharacterFactory>.instance; }
    }

    public GameObject prefabCharacter;

    public void Create(Vector3 position)
    {
        GameObject newCharacter = Instantiate(prefabCharacter, this.transform);
        newCharacter.transform.position = position;
    }

    public void CreateRandom()
    {
        Vector3 randomPosition = Vector3.zero;
        float x = UnityEngine.Random.Range(0f, (float) Screen.width);
        float y = UnityEngine.Random.Range(0f, (float) Screen.height);
        randomPosition = new Vector3(x, y, 0f);
        
        Create(randomPosition);
    }
}
