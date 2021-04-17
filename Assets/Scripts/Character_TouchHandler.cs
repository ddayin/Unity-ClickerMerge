using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_TouchHandler : MonoBehaviour
{
    /// <summary>
    /// 터치 다운일 때의 처리
    /// </summary>
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown()");
    }

    /// <summary>
    /// 터치 다운해서 드래그 중일 떄의 처리
    /// </summary>
    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag()");
    }

    /// <summary>
    /// 터치 업일 때의 처리
    /// </summary>
    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp()");
    }
}
