using UnityEngine;
using UnityEngine.UI;
using WanzyeeStudio;

public class UIBottom : MonoBehaviour
{
    public static UIBottom instance
    {
        get { return Singleton<UIBottom>.instance; }
    }

    private Button buttonCharacter;

    private void Awake()
    {
        buttonCharacter = transform.Find("Button_Character").GetComponent<Button>();
        buttonCharacter.onClick.AddListener(OnClickCharacter);
    }

    private void OnClickCharacter()
    {
        
    }
}
