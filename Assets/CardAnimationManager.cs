using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; // 特定の画像を、ある位置に移動させるライブラリDoTween

public class CardAnimationManager : MonoBehaviour
{
    // 移動先を用意する(窓口)
    [SerializeField] Transform endPoint;
    void Start()
    {
        transform.DOMove(endPoint.position, 2f);
        
    }

}
