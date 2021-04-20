using UnityEngine;
using UnityEngine.EventSystems;

public class Character_TouchHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler,
    IPointerDownHandler, IPointerUpHandler
{
    
    #region 유니티 이벤트 함수
    private void Start()
    {
        InvokeRepeating("ProcessTouch", 2f, 2f);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        
        ProcessTouch();
    }
    #endregion

    private void ProcessTouch()
    {
        CoinFactory.instance.Create(this.transform.position);
    }
}
