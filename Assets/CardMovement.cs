using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;  // マウスの動きを読み取る

public class CardMovement : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position; // Left Hand is your position = Right Hand is Mouse position
    }

}
