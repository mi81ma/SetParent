using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UnityのUIを扱うには、UnityEngine.UIをusing

public class GameManager : MonoBehaviour
{

    // 1. 取得： 変更したいTextを用意 (窓口)
    [SerializeField] Text viewText;
    void Start()
    {
        // 2. 変更: UIの値を変更する
        viewText.text = "Test UI";

    }
}
