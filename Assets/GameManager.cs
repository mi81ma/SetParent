using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // 1. 表示/非表示したいオブジェクトを用意(窓口)
    [SerializeField] GameObject panel;
    void Start()
    {
        // 2. 非表示
        // panel.SetActive(false);

        // 2'. 表示
        panel.SetActive(true);

    }
}
