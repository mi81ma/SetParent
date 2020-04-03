using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCard : MonoBehaviour
{
    // 生成したいオブジェクトを用意(窓口)
    public GameObject cardImage;
    
    // 親を用意(窓口)
    [SerializeField] Transform cardParent;
    
    void Start()
    {
        /*
        // 1.オブジェクトの生成
        GameObject cardObj = Instantiate(cardImage);
        // 2.親の設定
        cardObj.transform.SetParent(cardParent, false);
        */
        
        //別解
        Instantiate(cardImage, cardParent);
    }
}
